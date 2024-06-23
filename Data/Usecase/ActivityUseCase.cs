using FitnessTracker.Desktop.Data.Dto;
using FitnessTracker.Desktop.Domain.Model;
using FitnessTracker.Desktop.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FitnessTracker.Desktop.Constant;

namespace FitnessTracker.Desktop.Data.Usecase
{
    public class ActivityUseCase
    {
        private readonly IActivityRepository _activityRepository;
        public ActivityUseCase(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }
        public Result<dynamic> SaveActivity(Activity activity)
        {
            var result = new Result<dynamic>();
            int count;
            string message;
            var existingProfile = _activityRepository.GetActivity(activity.ID);
            if (existingProfile != null)
            {
                count = _activityRepository.UpdateActvity(activity);
                message = AppMessage.UPDATE_SUCCES;
            }
            else
            {
                count = _activityRepository.CreateActvity(activity);
                message = AppMessage.SAVE_SUCCES;
            }
            result.Success = count > 0;
            if (result.Success)
            {
                result.Message = message;
            }
            else
            {
                result.Message = AppMessage.ERROR_WHILE_SAVING;
            }
            return result;
        }
        public IEnumerable<Activity> GetAllActivities()
        {
            return _activityRepository.GetAllActivities();
        }
    }
}
