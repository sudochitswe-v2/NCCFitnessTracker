using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Common
{
    public static partial class Constant
    {
        public static class Message
        {
            public const string INVALID_USER_ID = "Invalid User ID";
            public const string INVALID_PASSWORD = "Invalid Password";
            public const string FATAL_THREAD_EXCEPTION_MESSAGE = "Fatal exception";
            public const string FATAL_UI_THREAD_EXCEPTION_MESSAGE = "Fatal exception happend inside UIThreadException handler";
            public const string UNHANDLE_THREAD_EXCEPTION = "Unhadled thread exception";
            public const string UNHANDLE_WINFORM_EXCEPTION = "Unhadled application exception";
        }
    }
    public static partial class Constant
    {
        public static class IdentityPrefix
        {
            public const char USER = 'U';
        }
    }
}
