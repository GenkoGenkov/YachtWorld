using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Models.Yacht;
using YachtWorld.Extensions;
using YachtWorld.Models;

namespace YachtWorld.Controllers
{
    [Authorize]
    public class YachtController : Controller
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

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllYachtsQueryModel query)
        {
            var result = await yachtService.All(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllYachtsQueryModel.YachtsPerPage);

            query.TotalYachtsCount = result.TotalYachtsCount;
            query.Categories = await yachtService.AllCategoriesNames();
            query.Yachts = result.Yachts;

            return View(query);
        }

        public async Task<IActionResult> Mine()
        {
            IEnumerable<YachtServiceModel> myYachts;
            var userId = User.Id();

            if (await yachtBrokerService.ExistsById(userId))
            {
                int yachtBrokerId = await yachtBrokerService.GetYachtBrokerId(userId);
                myYachts = await yachtService.AllYachtsByYachtBrokerId(yachtBrokerId);
            }
            else
            {
                myYachts = await yachtService.AllYachtsByUserId(userId);
            }

            return View(myYachts);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if ((await yachtService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await yachtService.YachtDetailsById(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if ((await yachtBrokerService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(YachtBrokerController.Become), "YachtBroker");
            }

            var model = new YachtModel()
            {
                YachtCategories = await yachtService.AllCategories(),
                YachtShipyards = await yachtService.AllShipyards(),
                YachtDestinations = await yachtService.AllDestinations()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(YachtModel model)
        {
            if ((await yachtBrokerService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(YachtBrokerController.Become), "YachtBroker");
            }

            if ((await yachtService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exists");
            }

            if (!ModelState.IsValid)
            {
                model.YachtCategories = await yachtService.AllCategories();
                model.YachtShipyards = await yachtService.AllShipyards();
                model.YachtDestinations = await yachtService.AllDestinations();


                return View(model);
            }

            int yachtBrokerId = await yachtBrokerService.GetYachtBrokerId(User.Id());

            int id = await yachtService.Create(model, yachtBrokerId);

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new YachtModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, YachtModel model)
        {
            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        public async Task<IActionResult> Vacate(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}
