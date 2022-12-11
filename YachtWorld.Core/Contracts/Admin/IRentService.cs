using YachtWorld.Core.Models.Admin;

namespace YachtWorld.Core.Contracts.Admin
{
    public interface IRentService
    {
        IEnumerable<RentServiceModel> All();
    }
}
