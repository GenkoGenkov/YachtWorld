using Microsoft.EntityFrameworkCore;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Models.Yacht;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Infrastructure.Data.Common;

namespace YachtWorld.Core.Services
{
    public class YachtService : IYachtService
    {
        private readonly IRepository repo;

        public YachtService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<YachtHomeModel>> FirstFiveYachts()
        {
            return await repo.AllReadonly<Yacht>()
                .OrderBy(y => y.Id)
                .Select(y => new YachtHomeModel()
                {
                    Id = y.Id,
                    ImageUrl = y.ImageUrl,
                    Title = y.Title,
                })
                .Take(5)
                .ToListAsync();
        }
    }
}
