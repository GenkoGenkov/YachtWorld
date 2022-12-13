using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Linq;
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

        //[Test]
        //public async Task TestHasYachtBrokerWithIdShouldReturnTrueWithValiId()
        //{
        //    var loggerMock = new Mock<ILogger<YachtService>>();
        //    logger = loggerMock.Object;

        //    var repo = new Repository(applicationDbContext);

        //    yachtService = new YachtService(repo, guard, logger);

        //    var yachtId = repo.All<Yacht>().Select(y => y.SailorId != null).FirstOrDefaultAsync().Id.ToString();
        //    var userId = repo.All<Yacht>().Select(y => y.SailorId != null).Select(b => b.YachtBroker.User.Id).ToString();
        //    int intYachtId = yachtId == null ? 0 : 1;
        //    var result = await yachtService.HasYachtBrokerWithId(intYachtId, userId);

        //    Assert.IsTrue(result);
        //}



        //[Test]
        //public async Task TestCreateShouldCreateYacht()
        //{
        //    var loggerMock = new Mock<ILogger<YachtService>>();
        //    logger = loggerMock.Object;

        //    var repo = new Repository(applicationDbContext);

        //    yachtService = new YachtService(repo, guard, logger);

        //    var initialYachts = repo.All<Yacht>().Count();

        //    var yacht = new Yacht()
        //    {
        //        Id = 19,
        //        Description = "",
        //        DestinationId = 4,
        //        ImageUrl = "",
        //        ShipyardId = 1,
        //        Title = ""
        //    };

        //    var newYachtId = await yachtService.Create(yacht, 1);

        //    var yachtCountAfterNewOne = repo.All<Yacht>().Count();

        //    Assert.That(yachtCountAfterNewOne, Is.EqualTo(initialYachts + 1));
        //}

        //[Test]
        //public async Task TestIsRentedByUserWithIdShouldReturnCorrectTrueWithValidId()
        //{
        //    var loggerMock = new Mock<ILogger<YachtService>>();
        //    logger = loggerMock.Object;

        //    var repo = new Repository(applicationDbContext);

        //    yachtService = new YachtService(repo, guard, logger);

        //    var yachtId = repo.All<Yacht>().Select(y => y.SailorId != null).FirstOrDefaultAsync().Id;
        //    var sailorId = repo.All<Yacht>().Select(y => y.SailorId != null);
        //}

        [Test]
        public async Task TestRentShouldRentYachtSuccessfully()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var yacht = new Yacht()
            {
                Id = 19,
                Description = "",
                DestinationId = 4,
                ImageUrl = "",
                ShipyardId = 1,
                Title = ""
            };

            await repo.AddAsync(yacht);
            await repo.SaveChangesAsync();

            var sailorId = yacht.SailorId;

            await yachtService.Rent(yacht.Id, sailorId);

            var yachtsInDb = applicationDbContext.Yachts.Find(yacht.Id);

            Assert.IsNotNull(yachtsInDb);
            Assert.That(sailorId, Is.EqualTo(yacht.SailorId));
        }

        [Test]
        public async Task TestVacateShouldReturnYachtSuccessfully()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var yacht = new Yacht()
            {
                Id = 19,
                Description = "",
                DestinationId = 4,
                ImageUrl = "",
                ShipyardId = 1,
                Title = ""
            };

            await repo.AddAsync(yacht);
            await repo.SaveChangesAsync();

            await yachtService.Vacate(yacht.Id);

            var yachtsInDb = applicationDbContext.Yachts.Find(yacht.Id);

            Assert.IsNull(yacht.SailorId);
            Assert.IsNotNull(yachtsInDb);
            Assert.IsNull(yachtsInDb.SailorId);
        }

        [Test]
        public async Task TestExistsShouldReturnCorrectTrueWithValidId()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var yachtId = repo.All<Yacht>().Select(y => y.SailorId != null).FirstOrDefaultAsync().Id;
            var result = await yachtService.Exists(yachtId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task TestIsRentedShouldReturnCorrectTrueWithValidId()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var yachtId = repo.All<Yacht>().Select(y => y.SailorId != null).FirstOrDefaultAsync().Id;
            var result = await yachtService.IsRented(yachtId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task TestGetYachtCategoryIdShouldReturnCorrectId()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var yachtId = repo.All<Yacht>().Select(y => y.SailorId != null).FirstOrDefaultAsync().Id;
            var result = await yachtService.GetYachtCategoryId(yachtId);

            Assert.IsNotNull(result);
        }

        [Test]
        public async Task TestCategoryExistsShouldReturnTrueWithValiId()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var categoryId = repo.All<Category>().FirstOrDefault().Id;
            var result = await yachtService.CategoryExists(categoryId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task TestYachtDetailsByIdShouldReturnCorrectYachtData()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var yachtId = repo.All<Yacht>().Select(y => y.SailorId != null).FirstOrDefault().ToString();
            int intYachtId = yachtId == null ? 0 : 1;
            var result = await yachtService.YachtDetailsById(intYachtId);
            var yachtsInDb = applicationDbContext.Yachts.Find(intYachtId);

            Assert.IsNotNull(result);
            Assert.That(result.Id, Is.EqualTo(yachtsInDb.Id));
            Assert.That(result.Title, Is.EqualTo(yachtsInDb.Title));
        }

        [Test]
        public async Task TestAllYachtsByUserIdShouldReturnCorrectYacht()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var sailorId = repo.All<Yacht>().Select(y => y.SailorId).FirstOrDefault().ToString();
            var result = await yachtService.AllYachtsByUserId(sailorId);
            var yachtsInDb = repo.All<Yacht>().Where(y => y.SailorId.ToString() == sailorId);

            Assert.IsNotNull(result);
            Assert.That(result.Count(), Is.EqualTo(yachtsInDb.Count()));
        }

        [Test]
        public async Task TestAllYachtsByYachtBrokerIdShouldReturnCorrectYacht()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var yachtBrokerId = repo.All<YachtBroker>().FirstOrDefault().ToString();
            var result = await yachtService.AllYachtsByUserId(yachtBrokerId);
            var yachtsInDb = repo.All<YachtBroker>().Where(y => y.Id.ToString() == yachtBrokerId);

            Assert.IsNotNull(result);
            Assert.That(result.Count(), Is.EqualTo(yachtsInDb.Count()));
        }

        [Test]
        public async Task TestAllCategoriesShouldReturnCorrectCategories()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var result = await yachtService.AllCategories();
            var dbCategories = repo.All<Category>();
            var categoryNames = dbCategories.Select(c => c.Name);

            Assert.That(result.Count(), Is.EqualTo(dbCategories.Count()));
            Assert.That(categoryNames.Contains(result.FirstOrDefault().Name));
        }

        [Test]
        public async Task TestAllShipyardsShouldReturnCorrectShipyard()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var result = await yachtService.AllShipyards();
            var dbCategories = repo.All<Shipyard>();
            var categoryNames = dbCategories.Select(c => c.Name);

            Assert.That(result.Count(), Is.EqualTo(dbCategories.Count()));
            Assert.That(categoryNames.Contains(result.FirstOrDefault().Name));
        }

        [Test]
        public async Task TestAllDestinationsShouldReturnCorrectDestinations()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var result = await yachtService.AllDestinations();
            var dbCategories = repo.All<Destination>();
            var categoryNames = dbCategories.Select(c => c.Name);

            Assert.That(result.Count(), Is.EqualTo(dbCategories.Count()));
            Assert.That(categoryNames.Contains(result.FirstOrDefault().Name));
        }

        [Test]
        public async Task TestAllCategorieNamesShouldReturnCorrectCategorieNames()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var result = await yachtService.AllCategoriesNames();
            var dbCategories = repo.All<Category>();
            var categoryNames = dbCategories.Select(c => c.Name);

            Assert.That(result.Count(), Is.EqualTo(dbCategories.Count()));
        }

        [Test]
        public async Task TestAllYachtShouldReturnCorrectYachts()
        {
            var loggerMock = new Mock<ILogger<YachtService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);

            yachtService = new YachtService(repo, guard, logger);

            var searchTerm = "First";
            var result = await yachtService.All(null, searchTerm);
            var yachtsInDb = repo.All<Yacht>().Where(y => y.Title.Contains(searchTerm));
            var resultYacht = result.Yachts.FirstOrDefault();
            var yachtInDb = yachtsInDb.FirstOrDefault();

            Assert.That(result.TotalYachtsCount, Is.EqualTo(yachtsInDb.Count()));
            Assert.IsNotNull(result);
            Assert.That(resultYacht?.Id, Is.EqualTo(yachtInDb?.Id));
            Assert.That(resultYacht?.Title, Is.EqualTo(yachtInDb?.Title));
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
                Id = 19,
                Description = "",
                DestinationId = 4,
                ImageUrl = "",
                ShipyardId = 1,
                Title = ""
            });

            await repo.SaveChangesAsync();

            await yachtService.Delete(19);

            var dbYacht = await repo.GetByIdAsync<Yacht>(19);

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
                Id = 19,
                Description = "",
                DestinationId = 4,
                ImageUrl = "",
                ShipyardId = 1,
                Title = ""
            });

            await repo.SaveChangesAsync();

            await yachtService.Edit(19, new YachtModel()
            {
                Id = 19,
                Description = "This yacht is edited",
                DestinationId = 4,
                ImageUrl = "",
                ShipyardId = 1,
                Title = ""
            });

            var dbYacht = await repo.GetByIdAsync<Yacht>(19);

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
                new Yacht() { Id = 19, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = "" },
                new Yacht() { Id = 21, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = "" },
                new Yacht() { Id = 20, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = "" },
                new Yacht() { Id = 24, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = ""},
                new Yacht() { Id = 22, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = "" },
                new Yacht() { Id = 23, Description = "", DestinationId = 2, ImageUrl = "", ShipyardId = 3, Title = "" },
            });

            await repo.SaveChangesAsync();

            var yachtCollection = await yachtService.FirstFiveYachts();

            Assert.That(5, Is.EqualTo(yachtCollection.Count()));
            Assert.That(yachtCollection.Any(y => y.Id == 24), Is.False);
        }

        [TearDown] 
        public void TearDown() 
        {
            applicationDbContext.Dispose();
        }
    }
}
