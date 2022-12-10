using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static YachtWorld.Areas.Admin.Constants.AdminConstants;

namespace YachtWorld.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Route("/Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = AdminRolleName)]

    public class BaseController : Controller
    {
    }
}
