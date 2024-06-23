using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
