using FitnessTracker.Desktop.Data.Dto;
using FitnessTracker.Desktop.Data.SqlClient;
using FitnessTracker.Desktop.Domain.Model;
using FitnessTracker.Desktop.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Data.Repository
{
    public class TrackingRepository : ITrackingRepository
    {
        private readonly DbClient _dbClient;
        public TrackingRepository(DbClient dbClient)
        {
            _dbClient = dbClient;
        }
        public IEnumerable<Goal> GetUserGoals(Guid userId)
        {
            var sql = "SELECT * FROM tb_Goal WHERE UserID=@UserID";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID",userId),
            };
            var result = _dbClient.Query<Goal>(sql, parameters);
            return result;
        }

        public int SaveGoal(Goal goal)
        {
            var properties = goal.GetType().GetProperties();
            var parameters = new List<SqlParameter>();
            foreach (var property in properties)
            {
                parameters.Add(new SqlParameter($"@{property.Name}", property.GetValue(goal)));
            }
            var columns = string.Join(",", properties.Select(prop => prop.Name));
            var values = string.Join(",", properties.Select(prop => $"@{prop.Name}"));
            var sql = $@"INSERT INTO tb_Goal ({columns}) VALUES ({values});";
            return _dbClient.Execute(sql, parameters);
        }
        public int UpdateGoal(Guid id, string status)
        {
            var sql = $@"UPDATE tb_Goal SET Status=@Status WHERE ID=@ID";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Status",status),
                new SqlParameter("@ID",id),
            };
            return _dbClient.Execute(sql, parameters);
        }
        public int SaveTracking(ActivityTracking activityTracking)
        {
            var properties = activityTracking.GetType().GetProperties();
            var parameters = new List<SqlParameter>();
            foreach (var property in properties)
            {
                parameters.Add(new SqlParameter($"@{property.Name}", property.GetValue(activityTracking)));
            }
            var columns = string.Join(",", properties.Select(prop => prop.Name));
            var values = string.Join(",", properties.Select(prop => $"@{prop.Name}"));
            var sql = $@"INSERT INTO tb_ActivityTracking ({columns}) VALUES ({values});";
            return _dbClient.Execute(sql, parameters);
        }
        public IEnumerable<TrackingResultDto> GetGoalTrackingResults(Guid userId)
        {
            var sql = @"SELECT 
                       	G.Name as Goal,
	                    A.Name as ActivityName,
	                    A.Metric1,
	                    ATT.Metric1Value,
	                    ATT.Metric2Value,
	                    ATT.Metric3Value,
	                    A.Metric2,
	                    A.Metric3,
	                    G.TargetCalories,
	                    ATT.BurnedCalories,
	                    G.Status
                        FROM
                        tb_ActivityTracking ATT
                        INNER JOIN tb_Goal G ON G.ID = ATT.GoalID
                        INNER JOIN tb_Activity A ON A.ID = ATT.ActivityID
                        WHERE G.UserID=@UserID";
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter("@UserID",userId)
            };
            var result = _dbClient.Query<TrackingResultDto>(sql, parameters);
            return result;
        }
    }
}
