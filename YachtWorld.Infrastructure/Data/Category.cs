using System.ComponentModel.DataAnnotations;

namespace YachtWorld.Infrastructure.Data
{
    public class Category
    {
        public Category()
        {
            Yachts = new List<Yacht>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public List<Yacht> Yachts { get; set; }
    }
}
