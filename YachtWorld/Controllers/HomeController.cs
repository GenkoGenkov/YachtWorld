using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YachtWorld.Core.Contracts;
using YachtWorld.Models;
using static YachtWorld.Areas.Admin.Constants.AdminConstants;

namespace YachtWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly IYachtService yachtService;

        private readonly ILogger logger;

        public HomeController(
            IYachtService _yachtService, 
            ILogger<HomeController> _logger)
        {
            yachtService = _yachtService;
            logger = _logger;
        }

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole(AdminRolleName))
            {
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }

            var model = await yachtService.FirstFiveYachts();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var feature = this.HttpContext.Features.Get<IExceptionHandlerFeature>();

            logger.LogError(feature.Error, "TraceIdentifier: {0}", Activity.Current?.Id ?? HttpContext.TraceIdentifier);

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}