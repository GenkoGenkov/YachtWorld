using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YachtWorld.Infrastructure.Data
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public string? MainAttraction { get; set; }

        [Required]
        public int YachtId { get; set; }

        [ForeignKey(nameof(YachtId))]
        public Yacht Yacht { get; set; } = null!;
    }
}
