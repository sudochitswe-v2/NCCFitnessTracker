
using System;

namespace FitnessTracker.Desktop.Domain.Model
{
    public class Role : BaseModel
    {
        public Guid ID { get; set; }
        public string RoleName { get; set; }
    }
}
