using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YachtWorld.Core.Models.Yacht;

namespace YachtWorld.Controllers
{
    [Authorize]
    public class YachtController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = new YachtsQueryModel();

            return View(model);
        }

        public async Task<IActionResult> Mine()
        {
            var model = new YachtsQueryModel();

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var model = new YachtDetailsModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(YachtModel model)
        {
            int id = 1;

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
