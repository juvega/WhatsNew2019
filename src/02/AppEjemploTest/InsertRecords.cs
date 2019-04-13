using AppEjemplo.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        private ClaimsDbContext _dbcontext;
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ClaimsDbContext>().UseNpgsql("User ID=netcore;Password=Welcome123!;Server=192.168.1.251;Port=5432;Database=claims_db;Integrated Security=true; Pooling=true;ApplicationName=claims_db;").Options;
            _dbcontext = new ClaimsDbContext(options);
        }

        [Test]
        public void Test1()
        {
            _dbcontext.Claims.AddRange(ClaimSeed.GenerateData());
            _dbcontext.SaveChanges();
            Assert.IsTrue(_dbcontext.Claims.Any());
        }
    }
}