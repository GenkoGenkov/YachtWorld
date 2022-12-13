using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YachtWorld.Core.Contracts;
using YachtWorld.Infrastructure.Data.Common;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Core.Contracts.Admin;
using YachtWorld.Core.Services;
using YachtWorld.Core.Services.Admin;

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
            //var resultYacht= result.ToList().Find(y => y.YachtTitle == )

            Assert.IsNotNull(result);
            Assert.AreEqual(rentedYachtsInDb.Count(), result.ToList().Count());
        }
    }
}
