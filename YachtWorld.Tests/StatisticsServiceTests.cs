using Microsoft.EntityFrameworkCore;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Services;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Infrastructure.Data.Common;

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
