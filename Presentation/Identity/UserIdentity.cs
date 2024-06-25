using FitnessTracker.Desktop.Data.Dto;
using FitnessTracker.Desktop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Identity
{
    public class UserIdentity
    {
        private UserIdentity() { }

        private static readonly UserIdentity _instance = new UserIdentity();
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }
        public UserProfile UserProfile { get; private set; }
        public void Init(UserDetail user)
        {
            this.Id = user.ID;
            this.Name = user.FullName;
            this.Email = user.Email;
            this.Role = user.Role.RoleName;
            this.UserProfile = user.Profile;
            this.UserProfile = user.Profile;
        }
        public static UserIdentity Instance
        {
            get => _instance;
        }
    }
}
