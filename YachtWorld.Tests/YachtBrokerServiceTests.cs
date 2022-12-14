using Microsoft.EntityFrameworkCore;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Services;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Infrastructure.Data.Common;

namespace YachtWorld.Tests
{
    [TestFixture]
    public class YachtBrokerServiceTests
    {
        private IRepository repo;
        private IYachtBrokerService yachtBrokerService;
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
        public async Task TestCreateYachtBrokerShouldWorkCorrectly()
        {
            var repo = new Repository(applicationDbContext);

            yachtBrokerService = new YachtBrokerService(repo);

            var initialBrokersCount = repo.All<YachtBroker>().Count();

            await yachtBrokerService.Create(repo.All<YachtBroker>().FirstOrDefault().UserId, repo.All<YachtBroker>().FirstOrDefault().PhoneNumber);

            var brokerCountAfter = repo.All<YachtBroker>().Count();
            var newBrokerId = await yachtBrokerService.GetYachtBrokerId(repo.All<YachtBroker>().FirstOrDefault().UserId);
            var newBrokerInDb = applicationDbContext.YachtBrokers.Find(newBrokerId);

            Assert.IsNotNull(newBrokerInDb);
            Assert.AreEqual(repo.All<YachtBroker>().FirstOrDefault().UserId, newBrokerInDb.UserId);
            Assert.AreEqual(repo.All<YachtBroker>().FirstOrDefault().PhoneNumber, newBrokerInDb.PhoneNumber);
        }

        [Test]
        public async Task TestUserWithPhoneNumberExistsShouldReturnTrueWithValidData()
        {
            var repo = new Repository(applicationDbContext);

            yachtBrokerService = new YachtBrokerService(repo);

            var result = await yachtBrokerService.UserWithEmailExists(repo.All<YachtBroker>().FirstOrDefault().PhoneNumber);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task TestExistsByIdIdShouldReturnTrueWithValidId()
        {
            var repo = new Repository(applicationDbContext);

            yachtBrokerService = new YachtBrokerService(repo);

            var result = await yachtBrokerService.ExistsById(repo.All<YachtBroker>().FirstOrDefault().UserId);

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task TestGetYachtBrokerIdShouldReturnCorrectUserId()
        {
            var repo = new Repository(applicationDbContext);

            yachtBrokerService = new YachtBrokerService(repo);

            var yachtBrokerId = repo.All<YachtBroker>().FirstOrDefault().UserId;
            var resultYachtBrokerId = await yachtBrokerService.GetYachtBrokerId(yachtBrokerId);

            Assert.AreEqual(repo.All<YachtBroker>().FirstOrDefault().Id, resultYachtBrokerId);
        }
    }
}
