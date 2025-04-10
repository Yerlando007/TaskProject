using AutoMapper;
using DataManager.Request;
using DataManager.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskProject.Mediatr.Good.Command;
using TaskProject.Mediatr.Good.Query;

namespace TaskProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GoodAddController : BaseController
{
    public GoodAddController(ISender sender, IMapper mapper)
    : base(sender, mapper) { }

    [HttpPost("AddGood")]
    public async Task<IActionResult> AddGood([FromForm] AddGoodRequest value)
    {
        var result = await _sender.Send(new AddGoodCommand(value));

        return Ok(result);
    }

    [HttpGet("GetAllGoods")]
    public async Task<IActionResult> GetAllGoods()
    {
        var result = await _sender.Send(new AllGoodQuery());

        if (result.IsFailed)
            return BadRequest(ProblemResponse(result.Error));

        return Ok(_mapper.Map<List<GoodsDto>>(result.Value));
    }
}