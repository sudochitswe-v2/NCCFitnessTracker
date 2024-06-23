using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Data.Dto
{
    public class Result<T>
    {
        public Result() { }

        public bool Status { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}
