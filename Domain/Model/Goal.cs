using System;

namespace FitnessTracker.Desktop.Domain.Model
{
    public class Goal : BaseModel
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public int TargetCalories { get; set; }
        public string Status { get; set; }
    }
}
