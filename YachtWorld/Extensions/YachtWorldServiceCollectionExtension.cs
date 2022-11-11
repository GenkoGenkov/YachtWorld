using YachtWorld.Core.Contracts;
using YachtWorld.Core.Services;
using YachtWorld.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class YachtWorldServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IYachtService, YachtService>();
            services.AddScoped<IYachtBrokerService, YachtBrokerService>();

            return services;
        }
    }
}
