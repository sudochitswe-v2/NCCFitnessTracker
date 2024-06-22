using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Util
{
    public static class FormatUtil
    {
        public static string IntToLeadingZeroString(int value, int noOfDegit, char prefix)
        {
            var degitFormat = "D" + noOfDegit;
            return value.ToString(degitFormat);
        }
    }
}
