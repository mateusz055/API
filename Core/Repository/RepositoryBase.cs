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
        private readonly DatabaseConfig _databaseConfig;
        public RepositoryBase(IOptions<DatabaseConfig> databaseConfig)
        {
            _databaseConfig = databaseConfig.Value;
        }

        protected async Task<List<TResult>> ConnectionOpen<TResult>(Func<SqlConnection,List<TResult>> action)
            
        {
            return await Task.Run(()=>
            {
                using (SqlConnection connection = new SqlConnection(_databaseConfig.ConectionString))
                {
                    connection.Open();
                    var file = action(connection);
                    return file;
                }
                
            });
            
        }
    }
}
