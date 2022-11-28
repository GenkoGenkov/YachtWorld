using YachtWorld.Core.Contracts;

namespace YachtWorld.Core.Models.Yacht
{
    public class YachtHomeModel : IYachtModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
    }
}
