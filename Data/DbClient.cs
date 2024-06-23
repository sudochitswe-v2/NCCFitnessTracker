using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using FitnessTracker.Desktop.Data.Context;
using Newtonsoft.Json;
using System.Linq;

namespace FitnessTracker.Desktop.Data.SqlClient
{
    public class DbClient
    {
        private readonly DataContext _dbContext;
        public DbClient(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T QueryFirstOrDefault<T>(string query, List<SqlParameter> parameters = null)
        {
            using (var connection = _dbContext.CreateConnection())
            {
                connection.Open();

                var cmd = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                connection.Close();
                string json = JsonConvert.SerializeObject(dt);
                var list = JsonConvert.DeserializeObject<List<T>>(json);
                return list.FirstOrDefault();
            }
        }
        public List<T> Query<T>(string query, List<SqlParameter> parameters = null)
        {
            using (var connection = _dbContext.CreateConnection())
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                connection.Close();
                string json = JsonConvert.SerializeObject(dt);
                var list = JsonConvert.DeserializeObject<List<T>>(json);
                return list;
            }

        }
        public int Execute(string sql, List<SqlParameter> parameters = null)
        {
            using (var conneciton = _dbContext.CreateConnection())
            {
                var cmd = new SqlCommand(sql, conneciton);
                conneciton.Open();
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                var result = cmd.ExecuteNonQuery();
                conneciton.Close();

                return result;
            }
        }
    }
}
