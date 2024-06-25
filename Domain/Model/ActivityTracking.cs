﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Domain.Model
{
    public class ActivityTracking : BaseModel
    {
        public Guid ID { get; set; }
        public Guid GoalID { get;set; }
        public Guid ActivityID { get; set; }
        public int Metric1Value { get; set; }
        public int Metric2Value { get; set; }
        public int Metric3Value { get; set; }
        public int BurnedCalories { get; set; }
    }
}
