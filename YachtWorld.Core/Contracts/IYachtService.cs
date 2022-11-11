using YachtWorld.Core.Models.Yacht;

namespace YachtWorld.Core.Contracts
{
    public interface IYachtService
    {
        Task<IEnumerable<YachtHomeModel>> FirstFiveYachts();
    }
}
