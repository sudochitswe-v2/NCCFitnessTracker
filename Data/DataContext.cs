using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Desktop.Data.Context
{
    public class DataContext
    {
        private readonly string _sqlConnection;
        public DataContext()
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "(local)\\SQLEXPRESS",
                InitialCatalog = "FitnessTrackerDb",
                UserID = "sa",
                Password = "admin",
                TrustServerCertificate = true,
            };
            _sqlConnection = connectionStringBuilder.ConnectionString;
        }
        public SqlConnection CreateConnection() => new SqlConnection(_sqlConnection);
    }
}
