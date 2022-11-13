using YachtWorld.Core.Models.Yacht;

namespace YachtWorld.Core.Contracts
{
    public interface IYachtService
    {
        Task<IEnumerable<YachtHomeModel>> FirstFiveYachts();

        Task<IEnumerable<YachtCategoryModel>> AllCategories();

        Task<bool> CategoryExists(int categoryId);

        Task<int> Create(YachtModel model, int yachtBrokerId);

    }
}
