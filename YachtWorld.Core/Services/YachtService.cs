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

        public async Task<IEnumerable<YachtDestinationModel>> AllDestinations()
        {
            return await repo.AllReadonly<Destination>()
                .OrderBy(d => d.Name)
                .Select(d => new YachtDestinationModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<YachtShipyardModel>> AllShipyards()
        {
            return await repo.AllReadonly<Shipyard>()
                .OrderBy(s => s.Name)
                .Select(s => new YachtShipyardModel()
                {
                    Id = s.Id,
                    Name = s.Name,
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
