using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YachtWorld.Core.Models.YachtBroker;

namespace YachtWorld.Controllers
{
    [Authorize]
    public class YachtBrokerController : Controller
    {
        [HttpGet]
        public IActionResult Become()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeYachtBrokerModel model)
        {
            return RedirectToAction("All", "Yacht");
        }
    }
}
