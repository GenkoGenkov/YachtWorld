using Microsoft.EntityFrameworkCore;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Exceptions;
using YachtWorld.Core.Services;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class YachtWorldApiServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IStatisticsService, StatisticsService>();
            services.AddScoped<IGuard, Guard>();

            return services;
        }

        public static IServiceCollection AddYachtRentingDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddScoped<IRepository, Repository>();

            return services;
        }
    }
}
