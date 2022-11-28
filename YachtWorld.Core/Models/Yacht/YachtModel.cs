using System.ComponentModel.DataAnnotations;
using YachtWorld.Core.Contracts;

namespace YachtWorld.Core.Models.Yacht
{
    public class YachtModel : IYachtModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(10000, MinimumLength = 50)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(300, MinimumLength = 5)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Display(Name = "Price for rent")]
        [Range(0.00, 2_000_000.00, ErrorMessage = "Price for rent must be a positive number and less than {2} leva")]
        public decimal PriceForRent { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Shipyard")]
        public int ShipyardId { get; set; }

        [Display(Name = "Destination")]
        public int DestinationId { get; set; }

        public IEnumerable<YachtCategoryModel> YachtCategories { get; set; } = new List<YachtCategoryModel>();

        public IEnumerable<YachtShipyardModel> YachtShipyards { get; set; } = new List<YachtShipyardModel>();

        public IEnumerable<YachtDestinationModel> YachtDestinations { get; set; } = new List<YachtDestinationModel>();


    }
}
