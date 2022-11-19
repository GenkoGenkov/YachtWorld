using YachtWorld.Core.Models.YachtBroker;

namespace YachtWorld.Core.Models.Yacht
{
    public class YachtDetailsModel : YachtServiceModel
    {
        public string Description { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Shipyard { get; set; } = null!;

        public string Destination { get; set; } = null!;

        public int? Guests { get; set; }

        public int? StateRooms { get; set; }

        public int? CrewMembers { get; set; }

        public string? Length { get; set; }

        public string? Engines { get; set; }

        public string? Generators { get; set; }

        public string? MaxSpeed { get; set; }

        public YachtBrokerServiceModel YachtBroker { get; set; }
    }
}
