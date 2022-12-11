using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Exceptions;
using YachtWorld.Core.Models.Yacht;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Infrastructure.Data.Common;

namespace YachtWorld.Core.Services
{
    public class YachtService : IYachtService
    {
        private readonly IRepository repo;
        private readonly IGuard guard;
        private readonly ILogger logger;

        public YachtService(
            IRepository _repo,
            IGuard _guard,
            ILogger<YachtService> _logger)
        {
            repo = _repo;
            guard = _guard;
            logger = _logger;
        }

        public async Task<YachtsQueryModel> All(string? category = null, string? searchTerm = null, YachtSorting sorting = YachtSorting.Newest, int currentPage = 1, int yachtsPerPage = 1)
        {
            var result = new YachtsQueryModel();

            var yachts = repo.AllReadonly<Yacht>()
                .Where(y => y.IsActive);

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
                .Where(y => y.IsActive)
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
                .Where(y => y.IsActive)
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

            try
            {
                await repo.AddAsync(yacht);
                await repo.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(nameof(Create), ex);
                throw new ApplicationException("Database failed to save info", ex);
            }

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
            yacht.ShipyardId = model.ShipyardId;
            yacht.DestinationId = model.DestinationId;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Yacht>()
                .AnyAsync(y => y.Id == id && y.IsActive);
        }

        public async Task<IEnumerable<YachtHomeModel>> FirstFiveYachts()
        {
            return await repo.AllReadonly<Yacht>()
                .Where(y => y.IsActive)
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

        public async Task<int> GetYachtShipyardId(int yachtId)
        {
            return (int)(await repo.GetByIdAsync<Yacht>(yachtId)).ShipyardId;
        }

        public async Task<int> GetYachtDestinationId(int yachtId)
        {
            return (int)(await repo.GetByIdAsync<Yacht>(yachtId)).DestinationId;
        }

        public async Task<bool> HasYachtBrokerWithId(int yachtId, string currentUser)
        {
            bool result = false;

            var yacht = await repo.AllReadonly<Yacht>()
                .Where(y => y.IsActive)
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
                .Where(y => y.IsActive)
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
                        PhoneNumber = y.YachtBroker.PhoneNumber
                    }

                })
                .FirstAsync();
        }

        public async Task Delete(int yachtId)
        {
            var yacht = await repo.GetByIdAsync<Yacht>(yachtId);
            yacht.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> IsRented(int yachtId)
        {
            return (await repo.GetByIdAsync<Yacht>(yachtId)).SailorId != null;
        }

        public async Task<bool> IsRentedByUserWithId(int yachtId, string currentUserId)
        {
            bool result = false;

            var yacht = await repo.AllReadonly<Yacht>()
                .Where(y => y.IsActive)
                .Where(y => y.Id == yachtId)
                .FirstOrDefaultAsync();

            if (yacht!= null && yacht.SailorId == currentUserId)
            {
                result = true;
            }

            return result;
        }

        public async Task Rent(int yachtId, string currentUserId)
        {
            var yacht = await repo.GetByIdAsync<Yacht>(yachtId);

            if (yacht != null && yacht.SailorId != null)
            {
                throw new ArgumentException("Yacht is already rented");
            }

            guard.AgainstNull(yacht, "Yacht can not be found");

            yacht.SailorId = currentUserId;

            await repo.SaveChangesAsync();
        }

        public async Task Vacate(int yachtId)
        {
            var yacht = await repo.GetByIdAsync<Yacht>(yachtId);
            guard.AgainstNull(yacht, "Yacht can not be found");
            yacht.SailorId = null;

            await repo.SaveChangesAsync();
        }
    }
}
