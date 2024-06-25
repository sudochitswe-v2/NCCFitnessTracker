using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop
{
    public static partial class Constant
    {
        public enum FormMode
        {
            NEW, EDIT
        }
        public static class AppMessage
        {
            public const string SAVE_SUCCES = "Save success.";
            public const string UPDATE_SUCCES = "Update success.";
            public const string ERROR_WHILE_SAVING = "Error while saving.";
            public const string DELETE_SUCCESS = "Delete success."; 
            public const string ERROR_WHILE_DELETING = "Error while deleting.";
            public const string INVALID_USER_ID = "Invalid User ID";
            public const string INVALID_PASSWORD = "Invalid Password";
            public const string FATAL_THREAD_EXCEPTION_MESSAGE = "Fatal exception";
            public const string FATAL_UI_THREAD_EXCEPTION_MESSAGE = "Fatal exception happend inside UIThreadException handler";
            public const string UNHANDLE_THREAD_EXCEPTION = "Unhadled thread exception";
            public const string UNHANDLE_WINFORM_EXCEPTION = "Unhadled application exception";
            public const string REGISTRATION_SUCCESS = "Registration success.";
            public const string REGISTRATION_UNSUCCESS = "Registration doesn't complete.";
            public const string DUPLICATE_EMAIL = "This email is already exist.";
        }
        public static class RoleName
        {
            public const string ADMIN = "Admin";
            public const string USER = "User";
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
