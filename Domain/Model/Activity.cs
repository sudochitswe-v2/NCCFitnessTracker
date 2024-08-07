using System;

namespace FitnessTracker.Desktop.Domain.Model
{
    public class Activity : BaseModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Metric1 { get; set; }
        public string Metric2 { get; set; }
        public string Metric3 { get; set; }
    }
}
