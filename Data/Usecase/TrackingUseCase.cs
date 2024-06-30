using FitnessTracker.Desktop.Data.Dto;
using FitnessTracker.Desktop.Domain.Model;
using FitnessTracker.Desktop.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using static FitnessTracker.Desktop.Constant;

namespace FitnessTracker.Desktop.Data.Usecase
{
    public class TrackingUseCase
    {
        private readonly ITrackingRepository _trackingRepository;
        public TrackingUseCase(ITrackingRepository trackingRepository)
        {
            _trackingRepository = trackingRepository;
        }
        public IEnumerable<Goal> GetGoals(Guid userId)
        {
            return _trackingRepository.GetUserGoals(userId);
        }
        public IEnumerable<TrackingResultDto> GetTrackingData(Guid userId, Guid goalId)
        {
            return _trackingRepository.GetGoalTrackingResults(userId, goalId);
        }
        public Result<int> UpdateGoalStatus(Guid id, string status)
        {
            var result = _trackingRepository.UpdateGoal(id, status);
            return new Result<int>
            {
                Success = result > 0,
                Message = result > 0 ? AppMessage.UPDATE_SUCCES : AppMessage.ERROR_WHILE_SAVING + "goal status",
                Data = result,
            };
        }
        public Result<int> SaveGoal(Goal goal)
        {
            var result = _trackingRepository.SaveGoal(goal);
            return new Result<int>
            {
                Message = result > 0 ? AppMessage.SAVE_SUCCES : AppMessage.ERROR_WHILE_SAVING,
                Data = result,
                Success = result > 0
            };
        }
        public Result<int> SaveTracking(ActivityTracking tracking)
        {
            var result = _trackingRepository.SaveTracking(tracking);
            return new Result<int>
            {
                Message = result > 0 ? AppMessage.SAVE_SUCCES : AppMessage.ERROR_WHILE_SAVING,
                Data = result,
                Success = result > 0
            };
        }
    }
}
