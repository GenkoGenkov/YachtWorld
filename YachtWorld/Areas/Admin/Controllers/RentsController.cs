using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using YachtWorld.Areas.Admin.Constants;
using YachtWorld.Core.Contracts.Admin;
using YachtWorld.Core.Models.Admin;

namespace YachtWorld.Areas.Admin.Controllers
{
    public class RentsController : BaseController
    {
        private readonly IRentService rents;
        private readonly IMemoryCache cache;

        public RentsController(
            IRentService _rents, 
            IMemoryCache _cache)
        {
            rents = _rents;
            cache = _cache;
        }

        public IActionResult All()
        {
            var rents = cache
                .Get<IEnumerable<RentServiceModel>>(AdminConstants.RentsCacheKey);

            if (rents == null)
            {
                rents = this.rents.All();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                cache.Set(AdminConstants.RentsCacheKey, rents, cacheOptions);
            }

            return View(rents);
        }
    }
}
