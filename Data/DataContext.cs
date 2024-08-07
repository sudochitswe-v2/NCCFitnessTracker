
using System.Data.SqlClient;

namespace FitnessTracker.Desktop.Data.Context
{
    public class DataContext
    {
        private readonly string _sqlConnection;
        public DataContext()
        {
            var connectionString = Properties.Settings.Default.FitnessTrackerDbConnectionString;
            _sqlConnection = connectionString;
        }
        public SqlConnection CreateConnection() => new SqlConnection(_sqlConnection);
    }
}
