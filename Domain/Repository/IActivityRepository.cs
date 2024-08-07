using FitnessTracker.Desktop.Domain.Model;
using System;
using System.Collections.Generic;

namespace FitnessTracker.Desktop.Domain.Repository
{
    public interface IActivityRepository
    {
        IEnumerable<Activity> GetAllActivities();
        Activity GetActivity(Guid Id);
        int CreateActvity(Activity activity);
        int UpdateActvity(Activity activity);
        int DeleteActvity(Activity activity);
    }
}
