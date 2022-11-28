using Microsoft.EntityFrameworkCore;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Models.Statistics;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Infrastructure.Data.Common;

namespace YachtWorld.Core.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IRepository repo;

        public StatisticsService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<StatisticsServiceModel> Total()
        {
            int totalYachts = await repo.AllReadonly<Yacht>()
                .CountAsync(h => h.IsActive);
            int rentedYachts = await repo.AllReadonly<Yacht>()
                .CountAsync(h => h.IsActive && h.SailorId != null);

            return new StatisticsServiceModel()
            {
                TotalYachts = totalYachts,
                TotalRents = rentedYachts
            };
        }
    }
}
