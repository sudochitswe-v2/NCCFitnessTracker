using System;
using System.Collections.Generic;
using System.Linq;
using FitnessTracker.Desktop.Data.Dto;
using FitnessTracker.Desktop.Domain.Interface;
using FitnessTracker.Desktop.Domain.Model;
using static FitnessTracker.Desktop.Constant;
namespace FitnessTracker.Desktop.Data.Usecase
{
    public class UserUseCase
    {
        private readonly IUserRepository _userRepo;
        public UserUseCase(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public IEnumerable<Role> GetRoles()
        {
            return _userRepo.GetRoles();
        }
        public Result<object> CheckIsEmailDuplicate(string email)
        {
            var result = new Result<object>();
            var user = _userRepo.GetUserByEmail(email);
            if (user is null)
                result.Success = true;
            else
            {
                result.Success = false;
                result.Message = AppMessage.DUPLICATE_EMAIL;
            }
            return result;
        }
        public Result<UserDetail> Login(string email, string password)
        {
            var result = new Result<UserDetail>();
            var user = _userRepo.GetUserByEmail(email);
            if (user is null)
            {
                result.Success = false;
                result.Message = AppMessage.INVALID_USER_ID;
                return result;
            }
            if (!user.Password.Equals(password))
            {
                result.Success = false;
                result.Message = AppMessage.INVALID_PASSWORD;
                return result;
            }
            var role = _userRepo.GetRoles().FirstOrDefault(r => r.ID.Equals(user.RoleID));
            var profile = _userRepo.GetUserProrile(user.ID);
            result.Success = true;
            result.Data = new UserDetail
            {
                ID = user.ID,
                RoleID = user.RoleID,
                FullName = user.FullName,
                Email = user.Email,
                Password = user.Password,
                Role = role,
                Profile = profile
            };
            return result;
        }

        public Result<dynamic> Register(User user)
        {
            var result = new Result<object>();
            var existingUser = _userRepo.GetUserByEmail(user.Email);
            if (existingUser != null)
            {
                result.Success = false;
                result.Message = AppMessage.DUPLICATE_EMAIL;
                return result;
            }
            var count = _userRepo.RegisterUser(user);
            if (count > 0)
            {
                result.Success = true;
                result.Message = AppMessage.REGISTRATION_SUCCESS;
            }
            else
            {
                result.Success = false;
                result.Message = AppMessage.REGISTRATION_UNSUCCESS;
            }
            return result;
        }
        public UserProfile GetUserProfile(Guid Id)
        {
            return _userRepo.GetUserProrile(Id);
        }
        public Result<dynamic> SaveProfile(UserProfile profile)
        {
            var result = new Result<dynamic>();
            int count;
            string message;
            var existingProfile = _userRepo.GetUserProrile(profile.UserID);
            if (existingProfile != null)
            {
                count = _userRepo.UpdateUserProfile(profile);
                message = AppMessage.UPDATE_SUCCES;
            }
            else
            {
                count = _userRepo.CreateUserProfile(profile);
                message = AppMessage.SAVE_SUCCES;
            }
            result.Success = count > 0;
            if (result.Success)
            {
                result.Message = message;
            }
            else
            {
                result.Message=AppMessage.ERROR_WHILE_SAVING;
            }
            return result;
        }
    }
}
