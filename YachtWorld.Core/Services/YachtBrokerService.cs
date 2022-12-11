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

        public async Task Create(string userId, string phoneNumber)
        {
            var yachtBroker = new YachtBroker()
            {
                UserId = userId,
                PhoneNumber = phoneNumber,
            };

            await repo.AddAsync(yachtBroker);
            await repo.SaveChangesAsync();
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<YachtBroker>()
                .AnyAsync(b => b.UserId == userId);
        }

        public async Task<int> GetYachtBrokerId(string userId)
        {
            return (await repo.AllReadonly<YachtBroker>()
                .FirstOrDefaultAsync(b => b.UserId == userId))?.Id ?? 0;
        }

        public async Task<bool> UserHasRents(string userId)
        {
            return await repo.All<Yacht>()
                .AnyAsync(y => y.SailorId == userId);
        }

        public async Task<bool> UserWithEmailExists(string phoneNumber)
        {
            return await repo.All<YachtBroker>()
                .AnyAsync(b => b.PhoneNumber == phoneNumber);
        }
    }
}
