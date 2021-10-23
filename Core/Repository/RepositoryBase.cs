using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Core.Repository
{
    public class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase(IOptions<Models.DatabaseConfigModel> options)
        {
            _connectionString = Convert.ToString(options);
        }

        public void ConnectionOpen(Action<SqlConnection> action)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                action(connection);
            }
        }
    }
}
