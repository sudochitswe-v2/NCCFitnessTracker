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
        private readonly string sqlConnection;
        public DataContext()
        {
            var sqlBuilder = new SqlConnectionStringBuilder()
            {

            };
        }
        public SqlConnection CreateConnection => new SqlConnection("");
    }
}
