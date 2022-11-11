using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YachtWorld.Core.Contracts;
using YachtWorld.Models;

namespace YachtWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly IYachtService yachtService;

        public HomeController(IYachtService _yachtService)
        {
            yachtService = _yachtService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await yachtService.FirstFiveYachts();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}