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

            var databaseConfig = Options.Create(new DatabaseConfig() { ConectionString = @"Server=DESKTOP-AL998SL\SQLEXPRESS;Database=files;Trusted_Connection=True;" });
            FileRepository fileRepository = new FileRepository(databaseConfig);
            fileRepository.GetAllRecords();
        }
    }
}