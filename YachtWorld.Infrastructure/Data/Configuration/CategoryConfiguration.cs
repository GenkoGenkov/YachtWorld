using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace YachtWorld.Infrastructure.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Green-Yachts"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Yacht-With-Captain"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Explorer"
                },

                new Category()
                {
                    Id = 4,
                    Name = "Large"
                }
            };

            return categories;
        }
    }
}
