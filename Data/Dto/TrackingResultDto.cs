using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Data.Dto
{
    public class TrackingResultDto
    {
        //public Guid ID { get; set; }
        public string Goal { get; set; }
        public string ActivityName { get; set; }
        public string Status { get; set; }
        public string Metric1 { get; set; }
        public int Metric1Value { get; set; }
        public string Metric2 { get; set; }
        public int Metric2Value { get; set; }
        public string Metric3 { get; set; }
        public int Metric3Value { get; set; }
        public int TargetCalories { get; set; }
        public int BurnedCalories { get; set; }

    }
}
