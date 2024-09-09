using DataManager.Requests;
using Microsoft.AspNetCore.Mvc;
using TaskProject.Mediatr.Positions.Command;
using TaskProject.Mediatr.Positions.Query;
using TaskProject.Mediatr.Worker.Command;

namespace TaskProject.Controllers
{
    public class PositionController : BaseController
    {
        [HttpPost("AddPositions")]
        public async Task<IActionResult> AddPositions()
        {
            var result = await _sender.Send(new AddPositionsCommand());
            return Ok(result);
        }

        [HttpGet("GetPositions")]
        public async Task<IActionResult> GetPositions()
        {
            var result = await _sender.Send(new GetPositionsQuery());
            return Ok(result);
        }
    }
}
