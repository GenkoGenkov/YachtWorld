using Microsoft.AspNetCore.Mvc;
using YachtWorld.Core.Contracts.Admin;

namespace YachtWorld.Areas.Admin.Controllers
{
    public class RentsController : BaseController
    {
        private readonly IRentService rents;

        public RentsController(IRentService _rents)
        {
            rents = _rents;
        }

        public IActionResult All()
        {
            var model = rents.All();

            return View(model);
        }
    }
}
