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

        public async Task<YachtsQueryModel> All(string? category = null, string? searchTerm = null, YachtSorting sorting = YachtSorting.Newest, int currentPage = 1, int yachtsPerPage = 1)
        {
            var result = new YachtsQueryModel();

            var yachts = repo.AllReadonly<Yacht>();

            if (string.IsNullOrEmpty(category) == false)
            {
                yachts = yachts
                    .Where(y => y.Category.Name == category);
            }

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                yachts = yachts
                    .Where(y => EF.Functions.Like(y.Title.ToLower(), searchTerm) ||
                                EF.Functions.Like(y.Description.ToLower(), searchTerm));
            }

            yachts = sorting switch
            {
                YachtSorting.Price => yachts
                    .OrderBy(y => y.PriceForRent),
                YachtSorting.NotRentedFirst => yachts
                    .OrderBy(y => y.SailorId),
                _ => yachts.OrderByDescending(y => y.Id)
            };

            result.Yachts = await yachts
                .Skip((currentPage - 1) * yachtsPerPage)
                .Take(yachtsPerPage)
                .Select(y => new YachtServiceModel()
                {
                    Id = y.Id,
                    ImageUrl = y.ImageUrl,
                    IsRented = y.SailorId != null,
                    PriceForRent = y.PriceForRent,
                    Title = y.Title,
                })
                .ToListAsync();

            result.TotalYachtsCount = await yachts.CountAsync();

            return result;
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

        public async Task<IEnumerable<string>> AllCategoriesNames()
        {
            return await repo.AllReadonly<Category>()
                .Select(c => c.Name)
                .Distinct()
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

        public async Task<IEnumerable<YachtServiceModel>> AllYachtsByUserId(string userId)
        {
            return await repo.AllReadonly<Yacht>()
                .Where(b => b.SailorId == userId)
                .Select(b => new YachtServiceModel()
                {
                    Id = b.Id,
                    ImageUrl = b.ImageUrl,
                    IsRented = b.SailorId != null,
                    PriceForRent = b.PriceForRent,
                    Title = b.Title,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<YachtServiceModel>> AllYachtsByYachtBrokerId(int id)
        {
            return await repo.AllReadonly<Yacht>()
                .Where(b => b.YachtBrokerId == id)
                .Select(b => new YachtServiceModel()
                {
                    Id = b.Id,
                    ImageUrl = b.ImageUrl,
                    IsRented = b.SailorId != null,
                    PriceForRent = b.PriceForRent,
                    Title = b.Title,
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

        public async Task Edit(int yachtId, YachtModel model)
        {
            var yacht = await repo.GetByIdAsync<Yacht>(yachtId);

            yacht.Description = model.Description;
            yacht.ImageUrl = model.ImageUrl;
            yacht.PriceForRent = model.PriceForRent;
            yacht.Title = model.Title;
            yacht.CategoryId = model.CategoryId;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Yacht>()
                .AnyAsync(y => y.Id == id);
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

        public async Task<int> GetYachtCategoryId(int yachtId)
        {
            return (await repo.GetByIdAsync<Yacht>(yachtId)).CategoryId;
        }

        public async Task<bool> HasYachtBrokerWithId(int yachtId, string currentUser)
        {
            bool result = false;

            var yacht = await repo.AllReadonly<Yacht>()
                .Where(y => y.Id == yachtId)
                .Include(y => y.YachtBroker)
                .FirstOrDefaultAsync();

            if (yacht?.YachtBroker != null && yacht.YachtBroker.UserId == currentUser)
            {
                result = true;
            }

            return result;
        }

        public async Task<YachtDetailsModel> YachtDetailsById(int id)
        {
            return await repo.AllReadonly<Yacht>()
                .Where(y => y.Id == id)
                .Select(y => new YachtDetailsModel()
                {
                    Category = y.Category.Name,
                    Shipyard = y.Shipyard.Name,
                    Destination = y.Destination.Name,
                    Description = y.Description,
                    Id = id,
                    ImageUrl = y.ImageUrl,
                    IsRented = y.SailorId != null,
                    PriceForRent = y.PriceForRent,
                    Title = y.Title,
                    CrewMembers = y.CrewMembers,
                    Engines = y.Engines,
                    Generators = y.Generators,
                    Guests = y.Guests,
                    MaxSpeed = y.MaxSpeed,
                    Length = y.Length,
                    StateRooms = y.StateRooms,
                    YachtBroker = new Models.YachtBroker.YachtBrokerServiceModel()
                    {
                        Email = y.YachtBroker.Email
                    }

                })
                .FirstAsync();
        }
    }
}
