using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Core.Models;

namespace Core.Repository
{
    public class RepositoryBase
    {
        private readonly DatabaseConfigModel _databaseConfigModel;
        public RepositoryBase(DatabaseConfigModel databaseConfigModel)
        {
            _databaseConfigModel = databaseConfigModel;
        }

        protected void ConnectionOpen(Action<SqlConnection> action)
        {
            using (SqlConnection connection = new SqlConnection(_databaseConfigModel.ConnectionString))
            {
                connection.Open();
                action(connection);
            }
        }
    }
}
