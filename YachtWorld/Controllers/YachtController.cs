using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using YachtWorld.Areas.Admin.Constants;
using YachtWorld.Core.Constants;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Extensions;
using YachtWorld.Core.Models.Yacht;
using YachtWorld.Extensions;
using YachtWorld.Models;
using static YachtWorld.Areas.Admin.Constants.AdminConstants;

namespace YachtWorld.Controllers
{
    [Authorize]
    public class YachtController : Controller
    {
        private readonly IYachtService yachtService;

        private readonly IYachtBrokerService yachtBrokerService;

        private readonly ILogger logger;

        private readonly IMemoryCache cache;

        public YachtController(
            IYachtService _yachtService, 
            IYachtBrokerService _yachtBrokerService,
            ILogger<YachtController> _logger,
            IMemoryCache _cache)
        {
            yachtService = _yachtService;
            yachtBrokerService = _yachtBrokerService;
            logger = _logger;
            cache = _cache;
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
            if (User.IsInRole(AdminRolleName))
            {
                return RedirectToAction("Mine", "Yacht", new { area = AreaName });
            }

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
        public async Task<IActionResult> Details(int id, string information)
        {
            if ((await yachtService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await yachtService.YachtDetailsById(id);

            if (information != model.GetInformation())
            {
                TempData["ErrorMessage"] = "Don't touch my URL!";

                return RedirectToAction("Index", "Home");
            }

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

            TempData[MessageConstant.SuccessMessage] = "You have successfully added a yacht!";

            return RedirectToAction(nameof(Details), new { id = id, information = model.GetInformation() });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await yachtService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await yachtService.HasYachtBrokerWithId(id, User.Id())) == false)
            {
                logger.LogInformation("User with id {0} attempted to access other yacht broker yacht", User.Id());

                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var yacht = await yachtService.YachtDetailsById(id);
            var categoryId = await yachtService.GetYachtCategoryId(id);
            var shipyardId = await yachtService.GetYachtShipyardId(id);
            var destinationId = await yachtService.GetYachtDestinationId(id);


            var model = new YachtModel()
            {
                Id = id,
                CategoryId = categoryId,
                ShipyardId = shipyardId,
                DestinationId = destinationId,
                Description = yacht.Description,
                ImageUrl = yacht.ImageUrl,
                PriceForRent = yacht.PriceForRent,
                Title = yacht.Title,
                YachtCategories = await yachtService.AllCategories(),
                YachtDestinations = await yachtService.AllDestinations(),
                YachtShipyards = await yachtService.AllShipyards(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, YachtModel model)
        {
            if (id != model.Id)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if ((await yachtService.Exists(model.Id)) == false)
            {
                ModelState.AddModelError("", "Yacht does not exist");

                model.YachtCategories = await yachtService.AllCategories();
                model.YachtDestinations = await yachtService.AllDestinations();
                model.YachtShipyards = await yachtService.AllShipyards();

                return View(model);
            }

            if ((await yachtService.HasYachtBrokerWithId(model.Id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if ((await yachtService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");

                model.YachtCategories = await yachtService.AllCategories();
                model.YachtDestinations = await yachtService.AllDestinations();
                model.YachtShipyards = await yachtService.AllShipyards();

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                model.YachtCategories = await yachtService.AllCategories();
                model.YachtDestinations = await yachtService.AllDestinations();
                model.YachtShipyards = await yachtService.AllShipyards();

                return View(model);
            }

            await yachtService.Edit(model.Id, model);

            TempData[MessageConstant.WarningMessage] = "You have successfully edited a yacht!";

            return RedirectToAction(nameof(Details), new { id = model.Id, information = model.GetInformation() });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await yachtService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await yachtService.HasYachtBrokerWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var yacht = await yachtService.YachtDetailsById(id);

            var model = new YachtDetailsViewModel()
            {
                ImageUrl = yacht.ImageUrl,
                Title = yacht.Title
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, YachtDetailsViewModel model)
        {
            if ((await yachtService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await yachtService.HasYachtBrokerWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            await yachtService.Delete(id);

            TempData[MessageConstant.WarningMessage] = "You have successfully deleted a yacht!";

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            if ((await yachtService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if (!User.IsInRole(AdminRolleName) && await yachtBrokerService.ExistsById(User.Id()))
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if (await yachtService.IsRented(id))
            {
                return RedirectToAction(nameof(All));
            }

            await yachtService.Rent(id, User.Id());

            TempData[MessageConstant.SuccessMessage] = "You have successfully rented a yacht!";

            cache.Remove(RentsCacheKey);

            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        public async Task<IActionResult> Vacate(int id)
        {
            if ((await yachtService.Exists(id)) == false || (await yachtService.IsRented(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await yachtService.IsRentedByUserWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            await yachtService.Vacate(id);

            TempData[MessageConstant.SuccessMessage] = "You have successfully vacated a yacht!";

            cache.Remove(RentsCacheKey);

            return RedirectToAction(nameof(Mine));
        }
    }
}
