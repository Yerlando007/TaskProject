using DataManager.Base;
using Microsoft.AspNetCore.Mvc;
using TaskProject.Mediatr.Query;

namespace TaskProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GoodAddController : BaseController
{
    [HttpPost("AddGood")]
    public async Task<IActionResult> AddGood([FromForm] AddGoodFormData value)
    {
        var result = await Sender.Send(new GoodAddQuery(value));
        return Ok(result);
    }
}
