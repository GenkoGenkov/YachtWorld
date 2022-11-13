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

        public async Task<IEnumerable<YachtCategoryModel>> AllCategories()
        {
            return await repo.AllReadonly<Category>()
                .OrderBy(c => c.Name)
                .Select(c => new YachtCategoryModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await repo.AllReadonly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task<int> Create(YachtModel model, int yachtBrokerId)
        {
            var yacht = new Yacht()
            {
                CategoryId = model.CategoryId,
                ShipyardId = model.ShipyardId,
                DestinationId = model.DestinationId,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                PriceForRent = model.PriceForRent,
                Title = model.Title,
                YachtBrokerId = yachtBrokerId
            };

            await repo.AddAsync(yacht);
            await repo.SaveChangesAsync();

            return yacht.Id;
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
