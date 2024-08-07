using System;

namespace FitnessTracker.Desktop.Domain.Model
{
    public abstract class BaseModel
    {
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        
    }
}
