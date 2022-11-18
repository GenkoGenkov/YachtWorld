namespace YachtWorld.Core.Models.Yacht
{
    public class YachtsQueryModel
    {
        public int TotalYachtsCount { get; set; }

        public IEnumerable<YachtServiceModel> Yachts { get; set; } = new List<YachtServiceModel>();
    }
}
