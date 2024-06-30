using FitnessTracker.Desktop.Data.Dto;
using FitnessTracker.Desktop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Domain.Repository
{
    public interface ITrackingRepository
    {
        IEnumerable<Goal> GetUserGoals(Guid userId);
        IEnumerable<TrackingResultDto> GetGoalTrackingResults(Guid userId,Guid goalId);
        int SaveGoal(Goal goal);
        int UpdateGoal(Guid id, string status);
        int SaveTracking(ActivityTracking activityTracking);
    }
}
