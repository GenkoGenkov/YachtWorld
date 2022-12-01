using YachtWorld.Core.Models.Yacht;

namespace YachtWorld.Areas.Admin.Models
{
    public class MyYachtsViewModel
    {
        public IEnumerable<YachtServiceModel> AddedYachts { get; set; }
            = new List<YachtServiceModel>();

        public IEnumerable<YachtServiceModel> RentedYachts { get; set; }
            = new List<YachtServiceModel>();
    }
}
