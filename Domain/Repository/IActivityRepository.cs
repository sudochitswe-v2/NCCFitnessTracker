using FitnessTracker.Desktop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
