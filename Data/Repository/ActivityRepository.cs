using FitnessTracker.Desktop.Domain.Repository;
using FitnessTracker.Desktop.Data.SqlClient;
using FitnessTracker.Desktop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Data.Repository
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly DbClient _dbClient;
        public ActivityRepository(DbClient dbClient)
        {
            _dbClient = dbClient;
        }
        public int CreateActvity(Activity activity)
        {
            var properties = activity.GetType().GetProperties();
            var parameters = new List<SqlParameter>();
            foreach (var property in properties)
            {
                parameters.Add(new SqlParameter($"@{property.Name}", property.GetValue(activity)));
            }
            var columns = string.Join(",", properties.Select(prop => prop.Name));
            var values = string.Join(",", properties.Select(prop => $"@{prop.Name}"));
            var sql = $@"INSERT INTO tb_Activity ({columns}) VALUES ({values});";
            return _dbClient.Execute(sql, parameters);
        }

        public int DeleteActvity(Activity activity)
        {
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter("@ID",activity.ID)
            };
            var sql = "DELETE FROM tb_Activity WHERE ID=@ID";
            return _dbClient.Execute(sql, parameters);
        }

        public Activity GetActivity(Guid Id)
        {
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter("@ID",Id)
            };
            var sql = "SELECT * FROM tb_Activity WHERE ID=@ID";
            return _dbClient.QueryFirstOrDefault<Activity>(sql, parameters);
        }

        public IEnumerable<Activity> GetAllActivities()
        {
            var sql = "SELECT * FROM tb_Activity;";
            return _dbClient.Query<Activity>(sql);
        }

        public int UpdateActvity(Activity activity)
        {
            var whereParam = nameof(activity.ID);
            var properties = activity.GetType().GetProperties().Where(prop => prop.Name != nameof(activity.ID));
            var parameters = new List<SqlParameter>
            {
                new SqlParameter($"@{whereParam}",  activity.ID)
            };
            foreach (var property in properties)
            {
                parameters.Add(new SqlParameter($"@{property.Name}", property.GetValue(activity)));
            }
            var cols = properties.Select(prop => prop.Name);

            var values = string.Join(",", cols.Select(col => $"{col}=@{col}"));
            var sql = $"UPDATE tb_Activity SET {values} WHERE {whereParam}=@{whereParam};";
            return _dbClient.Execute(sql, parameters);
        }
    }
}
