using Microsoft.EntityFrameworkCore;
using YachtWorld.Core.Contracts;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Infrastructure.Data.Common;

namespace YachtWorld.Core.Services
{
    public class YachtBrokerService : IYachtBrokerService
    {
        private readonly IRepository repo;

        public YachtBrokerService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(string userId, string email)
        {
            var yachtBroker = new YachtBroker()
            {
                UserId = userId,
                Email = email
            };

            await repo.AddAsync(yachtBroker);
            await repo.SaveChangesAsync();
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<YachtBroker>()
                .AnyAsync(b => b.UserId == userId);
        }

        public async Task<bool> UserHasRents(string userId)
        {
            return await repo.All<Yacht>()
                .AnyAsync(y => y.SailorId == userId);
        }

        public async Task<bool> UserWithEmailExists(string email)
        {
            return await repo.All<YachtBroker>()
                .AnyAsync(b => b.Email == email);
        }
    }
}
