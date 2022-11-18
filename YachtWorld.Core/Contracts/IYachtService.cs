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

    }
}
