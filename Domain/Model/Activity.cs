using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Domain.Model
{
    public class Activity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Metric1 { get; set; }
        public string Metric2 { get; set; }
        public string Metric3 { get; set; }
    }
}
