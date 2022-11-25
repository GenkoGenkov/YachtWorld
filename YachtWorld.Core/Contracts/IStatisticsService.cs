using YachtWorld.Core.Models.Statistics;

namespace YachtWorld.Core.Contracts
{
    public interface IStatisticsService
    {
        Task<StatisticsServiceModel> Total();
    }
}
