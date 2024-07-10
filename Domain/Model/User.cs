using System;

namespace FitnessTracker.Desktop.Domain.Model
{
    public class User : BaseModel
    {
        public Guid ID { get; set; }
        public Guid RoleID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
