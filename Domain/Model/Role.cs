using FitnessTracker.Desktop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Domain.Model
{
    public class Role : BaseModel
    {
        public Guid ID { get; set; }
        public string RoleName { get; set; }
    }
}
