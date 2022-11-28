using Microsoft.AspNetCore.Mvc;
using YachtWorld.Core.Contracts;
using YachtWorld.Core.Models.Statistics;

namespace YachtWorld.WebApi.Controllers
{
    [Route("api/statistics")]
    [ApiController]
    public class StatisticsApiController : ControllerBase
    {
        private readonly IStatisticsService service;

        public StatisticsApiController(IStatisticsService _service)
        {
            service = _service;
        }

        /// <summary>
        /// Gets statistics about number of yachts and rented yachts
        /// </summary>
        /// <returns>Total yachts and total rents</returns>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(StatisticsServiceModel))]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetStatistics()
        {
            var model = await service.Total();

            return Ok(model);
        }
    }
}