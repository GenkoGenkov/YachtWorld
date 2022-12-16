using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YachtWorld.Core.Contracts.Admin;
using YachtWorld.Core.Services.Admin;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Infrastructure.Data.Common;

namespace YachtWorld.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        private ApplicationDbContext applicationDbContext;
        private IUserService userService;
        private IRepository repo;
        private UserManager<ApplicationUser> userManager;
        private IUserStore<ApplicationUser> userStore;

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
        public async Task TestAllShouldReturnCorrectUsersAndYachtBrokers()
        {
            var store = new UserStore<ApplicationUser>(applicationDbContext);
            var repo = new Repository(applicationDbContext);

            userManager = new UserManager<ApplicationUser>(store: store, optionsAccessor: null, passwordHasher: null, userValidators: null, passwordValidators: null, keyNormalizer: null, errors: null, services: null, logger: null);
            userService = new UserService(repo, userManager);

            var result = await userService.All();
            var usersCount = applicationDbContext.Users.Count();
            var resultUsers = result.ToList();

            Assert.AreEqual(usersCount, resultUsers.Count());
        }
    }
}
