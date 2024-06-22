using FitnessTracker.Desktop.Domain.Models;
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
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public void Init(User user)
        {
            this.Id = user.UserID;
            this.Name = user.UserName;
            this.Email =user.Email;
        }
        public static UserIdentity Instance
        {
            get => _instance;
        }
    }
}
