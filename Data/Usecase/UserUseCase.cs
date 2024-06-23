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

        public Result<UserDetail> Login(string email, string password)
        {
            var result = new Result<UserDetail>();
            var user = _userRepo.GetUserByEmail(email);
            if (user is null)
            {
                result.Status = false;
                result.Message = AppMessage.INVALID_USER_ID;
                return result;
            }
            if (!user.Password.Equals(password))
            {
                result.Status = false;
                result.Message = AppMessage.INVALID_PASSWORD;
                return result;
            }
            var role = _userRepo.GetRoles().FirstOrDefault(r => r.ID.Equals(user.RoleID));
            var profile = _userRepo.GetUserProrile(user.ID);
            result.Status = true;
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

        public bool Register(User user)
        {
            var result = _userRepo.RegisterUser(user);
            return result > 0;
        }
    }
}
