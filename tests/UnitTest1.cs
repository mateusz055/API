using Core.Models;
using Core.Repository.Files;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using System.Data.SqlClient;

namespace tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            DatabaseConfigModel databaseConfigModel = new DatabaseConfigModel();
            databaseConfigModel.ConnectionString = @"Server=DESKTOP-AL998SL\SQLEXPRESS;Database=files;Trusted_Connection=True;";
            FileRepository fileRepository = new FileRepository(databaseConfigModel);
            fileRepository.GetAllRecords();
        }
        [Test]
        public void Test2()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=DESKTOP-AL998SL\SQLEXPRESS;Database=files;Trusted_Connection=True;"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM persons", connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}