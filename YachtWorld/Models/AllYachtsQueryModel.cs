using YachtWorld.Core.Models.Yacht;

namespace YachtWorld.Models
{
    public class AllYachtsQueryModel
    {
        public const int YachtsPerPage = 3;

        public string? Category { get; set; }

        public string? SearchTerm { get; set; }

        public YachtSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalYachtsCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<YachtServiceModel> Yachts { get; set; } = Enumerable.Empty<YachtServiceModel>();
    }
}
