using Microsoft.EntityFrameworkCore;
using YachtWorld.Core.Contracts.Admin;
using YachtWorld.Core.Services.Admin;
using YachtWorld.Infrastructure.Data;

namespace YachtWorld.Tests
{
    [TestFixture]
    public class RentServiceTests
    {
        private IRentService rentService;
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
        public async Task TestAllShouldReturnCorrectData()
        {
            rentService = new RentService(applicationDbContext);

            var result = this.rentService.All();
            var rentedYachtsInDb = applicationDbContext.Yachts.Where(y => y.SailorId != null);

            Assert.IsNotNull(result);
            Assert.AreEqual(rentedYachtsInDb.Count(), result.ToList().Count());
        }
    }
}
