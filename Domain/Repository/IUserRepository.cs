using FitnessTracker.Desktop.Data.Dto;
using FitnessTracker.Desktop.Domain.Model;
using System;
using System.Collections.Generic;

namespace FitnessTracker.Desktop.Domain.Interface
{
    public interface IUserRepository
    {
        UserDetail GetUserByEmail(string email);
        UserProfile GetUserProrile(Guid ID);
        IEnumerable<Role> GetRoles();
        int CreateUserProfile(UserProfile profile);
        int UpdateUserProfile(UserProfile profile);
        int RegisterUser(User user);
    }
}
