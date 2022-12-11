using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YachtWorld.Core.Constants;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Models.YachtBroker;
using YachtWorld.Extensions;

namespace YachtWorld.Controllers
{
    [Authorize]
    public class YachtBrokerController : Controller
    {
        private readonly IYachtBrokerService yachtBrokerService;

        public YachtBrokerController(IYachtBrokerService _yachtBrokerService)
        {
            yachtBrokerService = _yachtBrokerService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await yachtBrokerService.ExistsById(User.Id()))
            {
                TempData[MessageConstant.ErrorMessage] = "You are alredy an yacht broker";

                return RedirectToAction("Index", "Home");
            }

            var model = new BecomeYachtBrokerModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeYachtBrokerModel model)
        {
            var userId = User.Id();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await yachtBrokerService.ExistsById(userId))
            {
                TempData[MessageConstant.ErrorMessage] = "You are alredy an yacht broker";

                return RedirectToAction("Index", "Home");
            }

            //if (await yachtBrokerService.UserWithEmailExists(model.PhoneNumber))
            //{
            //    TempData[MessageConstant.ErrorMessage] = "The email alredy exists";

            //    return RedirectToAction("Index", "Home");
            //}

            if (await yachtBrokerService.UserHasRents(userId))
            {
                TempData[MessageConstant.ErrorMessage] = "You must have no rents to become yacht broker";

                return RedirectToAction("Index", "Home");
            }

            await yachtBrokerService.Create(userId, model.PhoneNumber);

            return RedirectToAction("All", "Yacht");
        }
    }
}
