using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Core.Models;
using Core.Interfaces;

namespace Core.Repository.Files
{
    public class FileRepository : RepositoryBase, IFileRepository
    {
        public FileRepository(IOptions<DatabaseConfig> databaseConfig) : base(databaseConfig)
        {

        }
        public async Task GetAllRecords()
        {
            await ConnectionOpen(GetPersons);

        }
        private void GetPersons(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Files", connection);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var s = dataReader.GetValue(1);
            }
        }
    }

}
