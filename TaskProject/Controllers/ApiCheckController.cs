using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskProject.Mediatr.Api.Query;

namespace TaskProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ApiCheckController : BaseController
    {
        public ApiCheckController(ISender sender, IMapper mapper)
            : base(sender, mapper) { }

        [HttpPost("ApiCheck")]
        public async Task<IActionResult> ApiCheck()
        {
            var result = await _sender.Send(new GetRequestCheckQuery());

            if (result.IsFailed)
                return BadRequest(ProblemResponse(result.Error));

            return Ok(result.Value);
        }
    }
}
