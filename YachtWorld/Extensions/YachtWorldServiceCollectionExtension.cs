using YachtWorld.Core.Contracts;
using YachtWorld.Core.Contracts.Admin;
using YachtWorld.Core.Exceptions;
using YachtWorld.Core.Services;
using YachtWorld.Core.Services.Admin;
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
            services.AddScoped<IGuard, Guard>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRentService, RentService>();

            return services;
        }
    }
}
