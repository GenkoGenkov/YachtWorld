using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Exceptions;
using YachtWorld.Core.Models.Yacht;
using YachtWorld.Core.Services;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Infrastructure.Data.Common;

namespace YachtWorld.Tests
{
    [TestFixture]
    public class YachtServiceTests
    {
        private IRepository repo;
        private ILogger<YachtService> logger;
        private IGuard guard;
        private IYachtService yachtService;
        private ApplicationDbContext applicationDbContext;

        [SetUp]
        public void Setup()
        {
            guard = new Guard();

            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("YachtDB")
                .Options;

            applicationDbContext = new ApplicationDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task TestYachtDelete()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            await repo.AddAsync(new Yacht()
            {
                Id = 1,
                Description = "",
                DestinationId = 4,
                ImageUrl = "",
                ShipyardId = 1,
                Title = ""
            });

            await repo.SaveChangesAsync();

            await yachtService.Delete(1);

            var dbYacht = await repo.GetByIdAsync<Yacht>(1);

            Assert.That(dbYacht.IsActive, Is.EqualTo(false));
        }

        [Test]
        public async Task TestYachtEdit()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            await repo.AddAsync(new Yacht()
            {
                Id = 1,
                Description = "",
                DestinationId = 4,
                ImageUrl = "",
                ShipyardId = 1,
                Title = ""
            });

            await repo.SaveChangesAsync();

            await yachtService.Edit(1, new YachtModel()
            {
                Id = 1,
                Description = "This yacht is edited",
                DestinationId = 4,
                ImageUrl = "",
                ShipyardId = 1,
                Title = ""
            });

            var dbYacht = await repo.GetByIdAsync<Yacht>(1);

            Assert.That(dbYacht.Description, Is.EqualTo("This yacht is edited"));
        }

        [Test]
        public async Task TestFirstFiveYachtsInMemory()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            await repo.AddRangeAsync(new List<Yacht>()
            {
                new Yacht() { Id = 1, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = "" },
                new Yacht() { Id = 6, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = "" },
                new Yacht() { Id = 2, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = "" },
                new Yacht() { Id = 5, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = ""},
                new Yacht() { Id = 3, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = "" },
                new Yacht() { Id = 4, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = "" },
            });

            await repo.SaveChangesAsync();

            var yachtCollection = await yachtService.FirstFiveYachts();

            Assert.That(5, Is.EqualTo(yachtCollection.Count()));
            Assert.That(yachtCollection.Any(y => y.Id == 6), Is.False);
        }

        //[Test]
        //public async Task TestFirstFiveYachtsNumberAndOrder()
        //{
        //    var loggerMock = new Mock<ILogger<YachtService>>();
        //    logger = loggerMock.Object;

        //    var repoMock = new Mock<IRepository>();
        //    IQueryable<Yacht> yachts = new List<Yacht>()
        //    {
        //        new Yacht() { Id = 1 },
        //        new Yacht() { Id = 6 },
        //        new Yacht() { Id = 2 },
        //        new Yacht() { Id = 5 },
        //        new Yacht() { Id = 3 },
        //        new Yacht() { Id = 4 },
        //    }.AsQueryable();
        //    repoMock.Setup(r => r.AllReadonly<Yacht>()).Returns(yachts);
        //    repo = repoMock.Object;

        //    yachtService = new YachtService(repo, guard, logger);

        //    var yachtCollection = await yachtService.FirstFiveYachts();

        //    Assert.That(5, Is.EqualTo(yachtCollection.Count()));
        //    Assert.That(yachtCollection.Any(y => y.Id == 6), Is.False);
        //}

        [TearDown] 
        public void TearDown() 
        {
            applicationDbContext.Dispose();
        }
    }
}
