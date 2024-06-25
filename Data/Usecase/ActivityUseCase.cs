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
            var existing = _activityRepository.GetActivity(activity.ID);
            if (existing != null)
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
        public Result<dynamic> DeleteActitiy(Activity activity)
        {
            var result = _activityRepository.DeleteActvity(activity);
            return new Result<dynamic>
            {
                Data = result,
                Message = result > 0 ? AppMessage.DELETE_SUCCESS : AppMessage.ERROR_WHILE_DELETING,
                Success = result > 0
            };
        }
        public IEnumerable<Activity> GetAllActivities()
        {
            return _activityRepository.GetAllActivities();
        }
    }
}
