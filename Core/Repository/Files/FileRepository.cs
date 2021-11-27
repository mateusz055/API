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
        public async Task<List<File>> GetAll()
        {
            return await ConnectionOpen<File>(GetPersons);
            
        }
        private List<File> GetPersons(SqlConnection connection)
        {
            var fileslist = new List<File>();
            SqlCommand command = new SqlCommand("SELECT * FROM Files", connection);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {               
                fileslist.Add(new File()
                {
                    Id = (int)dataReader.GetValue(0),
                    Filenames = (string)dataReader.GetValue(1),
                    Size = (string)dataReader.GetValue(2),
                    Type = (string)dataReader.GetValue(3)
                });
            }
            return fileslist;
        }
    }

}
