using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Core.Models;

namespace Core.Repository.Files
{
    public class FileRepository : RepositoryBase
    { 
        public FileRepository(IOptions<DatabaseConfigModel> options): base(options)
        {

        }
        public void GetAllRecords() 
        {
            ConnectionOpen(SqlAction);
            
        }
        private void SqlAction(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Persons",connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
                Console.WriteLine(dataReader.GetValue(0));
            }
        }
    }

}
