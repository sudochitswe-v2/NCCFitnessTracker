using System;
namespace FitnessTracker.Desktop.Domain.Model
{
    public class UserProfile : BaseModel
    {
        public Guid UserID { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }  
    }

}
