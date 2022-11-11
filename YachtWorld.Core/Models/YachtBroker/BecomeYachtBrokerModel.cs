using System.ComponentModel.DataAnnotations;

namespace YachtWorld.Core.Models.YachtBroker
{
    public class BecomeYachtBrokerModel
    {
        [Required]
        [StringLength(50, MinimumLength = 17)]
        [EmailAddress]
        public string Email { get; set; } = null!;
    }
}
