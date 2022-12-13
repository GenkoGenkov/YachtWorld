using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YachtWorld.Core.Contracts;
using YachtWorld.Infrastructure.Data.Common;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Core.Services;

namespace YachtWorld.Tests
{
    [TestFixture]
    public class StatisticsServiceTests
    {
        private IRepository repo;
        private IStatisticsService statisticsService;
        private ApplicationDbContext applicationDbContext;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("YachtDB")
                .Options;

            applicationDbContext = new ApplicationDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task TestTotalShouldReturnCorrectCounts()
        {
            var repo = new Repository(applicationDbContext);

            statisticsService = new StatisticsService(repo);

            var result = await statisticsService.Total();
            var yachtsCount = applicationDbContext.Yachts.Count();
            var rentsCount = applicationDbContext.Yachts.Where(y => y.SailorId != null).Count();

            Assert.IsNotNull(result);
            Assert.AreEqual(yachtsCount, result.TotalYachts);
            Assert.AreEqual(rentsCount, result.TotalRents);
        }
    }
}
