using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YachtWorld.Infrastructure.Data
{
    public class Yacht
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength (10000)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(300)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal PriceForRent { get; set; }

        public int? Guests { get; set; }

        public int? StateRooms { get; set; }

        public int? CrewMembers { get; set; }

        public string? Length { get; set; }

        public string? Engines { get; set; }

        public string? Generators { get; set; }

        public string? MaxSpeed { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int YachtBrokerId { get; set; }

        [ForeignKey(nameof(YachtBrokerId))]
        public YachtBroker YachtBroker { get; set; } = null!;

        public string? SailorId { get; set; }

        [ForeignKey(nameof(SailorId))]
        public IdentityUser? Sailor { get; set; }

        public int? ShipyardId { get; set; }

        [ForeignKey(nameof(ShipyardId))]
        public Shipyard Shipyard { get; set; } = null!;

        public int? DestinationId { get; set; }

        [ForeignKey(nameof(DestinationId))]
        public Destination Destination { get; set; } = null!;

        public bool IsActive { get; set; } = true;
    }
}
