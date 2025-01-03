﻿using FitnessTracker.Desktop.Domain.Model;
using System;

namespace FitnessTracker.Desktop.Data.Dto
{
    public class UserDetail
    {
        public Guid ID { get; set; }
        public Guid RoleID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public UserProfile Profile { get; set; }
    }
}
