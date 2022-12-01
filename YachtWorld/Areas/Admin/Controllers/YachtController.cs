using Microsoft.AspNetCore.Mvc;
using YachtWorld.Areas.Admin.Models;
using YachtWorld.Core.Contracts;
using YachtWorld.Extensions;

namespace YachtWorld.Areas.Admin.Controllers
{
    public class YachtController : BaseController
    {
        private readonly IYachtService yachtService;
        private readonly IYachtBrokerService yachtBrokerService;

        public YachtController(
            IYachtService _yachtService, 
            IYachtBrokerService _yachtBrokerService)
        {
            yachtService = _yachtService;
            yachtBrokerService = _yachtBrokerService;
        }

        public async Task<IActionResult> Mine()
        {
            var myYachts = new MyYachtsViewModel();
            var adminId = User.Id();

            myYachts.RentedYachts = await yachtService.AllYachtsByUserId(adminId);

            var yachtBrokerId = await yachtBrokerService.GetYachtBrokerId(adminId);

            myYachts.AddedYachts = await yachtService.AllYachtsByYachtBrokerId(yachtBrokerId);

            return View(myYachts);
        }
    }
}
