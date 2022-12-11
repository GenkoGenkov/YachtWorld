using System.ComponentModel.DataAnnotations;

namespace YachtWorld.Core.Models.YachtBroker
{
    public class BecomeYachtBrokerModel
    {
        [Required]
        [StringLength(15, MinimumLength = 7)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;
    }
}
