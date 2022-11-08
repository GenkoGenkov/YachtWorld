using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YachtWorld.Infrastructure.Data
{
    public class Yacht
    {
        public Yacht()
        {
            Destinations = new List<Destination>();
        }

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
        [Precision(18, 3)]
        public decimal PriceForRent { get; set; }

        [Required]
        public int Guests { get; set; }

        [Required]
        public int StateRooms { get; set; }

        [Required]
        public int CrewMembers { get; set; }

        [Required]
        public string Length { get; set; } = null!;

        public string? Engines { get; set; }

        public string? Generators { get; set; }

        [Required]
        public string MaxSpeed { get; set; } = null!;

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

        [Required]
        public int ShipyardId { get; set; }

        [ForeignKey(nameof(ShipyardId))]
        public Shipyard Shipyard { get; set; } = null!;

        public List<Destination> Destinations { get; set; }
    }
}
