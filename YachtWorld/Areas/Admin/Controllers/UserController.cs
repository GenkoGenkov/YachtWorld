using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using YachtWorld.Areas.Admin.Constants;
using YachtWorld.Core.Constants;
using YachtWorld.Core.Contracts.Admin;
using YachtWorld.Core.Models.Admin;

namespace YachtWorld.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService userService;
        private readonly IMemoryCache cache;

        public UserController(
            IUserService _userService, 
            IMemoryCache _cache)
        {
            userService = _userService;
            cache = _cache;
        }

        public async Task<IActionResult> All()
        {
            var users = cache
                .Get<IEnumerable<UserServiceModel>>(AdminConstants.UserCacheKey);

            if (users == null)
            {
                users = await userService.All();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                cache.Set(AdminConstants.UserCacheKey, users, cacheOptions);
            }

            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> Forget(string userId)
        {
            bool result = await userService.Forget(userId);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "User is now forgotten";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = "User can not be forgotten";
            }

            return RedirectToAction(nameof(All));
        }
    }
}
