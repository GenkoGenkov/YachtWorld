using System.ComponentModel.DataAnnotations;

namespace YachtWorld.Core.Models.Yacht
{
    public class YachtServiceModel
    {
        public int Id { get; init; }

        public string Title { get; init; } = null!;

        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; } = null!;

        [Display(Name = "Price for rent")]
        public decimal PriceForRent { get; init; }

        [Display(Name = "Is Rented")]
        public bool IsRented { get; init; }
    }
}
