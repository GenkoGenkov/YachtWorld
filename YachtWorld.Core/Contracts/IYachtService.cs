using YachtWorld.Core.Models.Yacht;

namespace YachtWorld.Core.Contracts
{
    public interface IYachtService
    {
        Task<IEnumerable<YachtHomeModel>> FirstFiveYachts();

        Task<IEnumerable<YachtCategoryModel>> AllCategories();

        Task<IEnumerable<YachtShipyardModel>> AllShipyards();

        Task<IEnumerable<YachtDestinationModel>> AllDestinations();

        Task<bool> CategoryExists(int categoryId);

        Task<int> Create(YachtModel model, int yachtBrokerId);

        Task<YachtsQueryModel> All(
            string? category = null,
            string? searchTerm = null,
            YachtSorting sorting = YachtSorting.Newest,
            int currentPage = 1,
            int yachtsPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNames();

        Task<IEnumerable<YachtServiceModel>> AllYachtsByYachtBrokerId(int id);

        Task<IEnumerable<YachtServiceModel>> AllYachtsByUserId(string userId);

        Task<YachtDetailsModel> YachtDetailsById(int id);

        Task<bool> Exists(int id);

        Task Edit(int yachtId, YachtModel model);

        Task<bool> HasYachtBrokerWithId(int yachtId, string currentUser);

        Task<int> GetYachtCategoryId(int yachtId);

        Task<int> GetYachtShipyardId(int yachtId);

        Task<int> GetYachtDestinationId(int yachtId);

    }
}
