using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace YachtWorld.Infrastructure.Data.Configuration
{
    internal class YachtBrokerConfiguration : IEntityTypeConfiguration<YachtBroker>
    {
        public void Configure(EntityTypeBuilder<YachtBroker> builder)
        {
            builder.HasData(new YachtBroker()
            {
                Id = 1,
                Email = "yachtBroker@mail.com",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            });
        }
    }
}
