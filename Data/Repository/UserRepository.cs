using System;
using FitnessTracker.Desktop.Domain.Interface;
using System.Data.SqlClient;
using FitnessTracker.Desktop.Domain.Models;
using FitnessTracker.Desktop.Data.SqlClient;
using System.Collections.Generic;
using FitnessTracker.Desktop.Domain.Model;
using System.Linq;
using FitnessTracker.Desktop.Data.Dto;

namespace FitnessTracker.Desktop.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DbClient _dbClient;
        public UserRepository(DbClient dbClient)
        {
            _dbClient = dbClient;
        }
        public int RegisterUser(User user)
        {
            var properties = user.GetType().GetProperties();
            var parameters = new List<SqlParameter>();
            foreach (var property in properties)
            {
                parameters.Add(new SqlParameter($"@{property.Name}", property.GetValue(user)));
            }
            var cols = properties.Select(prop => prop.Name);
            var columns = string.Join(",", cols);
            var values = string.Join(",", cols.Select(col => $"@{col}"));
            var sql = $"INSERT INTO tb_SystemUser ({columns}) VALUES ({values});";
            return _dbClient.Execute(sql, parameters);
        }
        public UserDetail GetUserByEmail(string email)
        {
            var sql = @"SELECT TOP 1 
                        	SU.*,
                        	R.RoleName
                        	FROM tb_SystemUser SU
                        	INNER JOIN tb_Role R ON SU.RoleID = R.ID
                        WHERE Email = @Email";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Email",email),
            };

            return _dbClient.QueryFirstOrDefault<UserDetail>(sql, parameters);
        }

        public UserProfile GetUserProrile(Guid ID)
        {
            var sql = @"SELECT TOP 1 
                        	   [UserID]
                              ,[Weight]
                              ,[Height]
                              ,[Gender]
                              ,[DateOfBirth]
                              ,[CreatedBy]
                              ,[CreatedOn]
                              ,[ModifiedBy]
                              ,[ModifiedOn]
                        FROM [dbo].[tb_UserProfile]
                        WHERE UserID = @UserID";
            var paramters = new List<SqlParameter>
            {
                new SqlParameter("@UserID",ID)
            };
            return _dbClient.QueryFirstOrDefault<UserProfile>(sql, paramters);
        }

        public IEnumerable<Role> GetRoles()
        {
            var sql = "SELECT TOP 10 * FROM tb_Role";
            return _dbClient.Query<Role>(sql);
        }
    }
}
