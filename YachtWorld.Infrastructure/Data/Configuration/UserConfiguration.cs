using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace YachtWorld.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(p => p.IsActive).HasDefaultValue(true);

            builder.HasData(CreateUsers());
        }

        private List<ApplicationUser> CreateUsers()
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            var yachtBrokerUser = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "yachtBroker@mail.com",
                NormalizedUserName = "YACHTBROKER@MAIL.COM",
                Email = "yachtBroker@mail.com",
                NormalizedEmail = "YACHTBROKER@MAIL.COM"
            };

            yachtBrokerUser.PasswordHash = hasher.HashPassword(yachtBrokerUser, "yachtBroker123");

            users.Add(yachtBrokerUser);

            var guestUser = new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "GUEST@MAIL.COM",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@MAIL.COM"
            };

            guestUser.PasswordHash = hasher.HashPassword(guestUser, "guest123");

            users.Add(guestUser);

            return users;
        }

    }
}
