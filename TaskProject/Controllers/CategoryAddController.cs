using DataManager.Base;
using Microsoft.AspNetCore.Mvc;
using TaskProject.Controllers;
using TaskProject.Mediatr.CategoryMediatr.Query;

namespace TestMediatorApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryAddController : BaseController
{
    [HttpPost("AddCategory")]
    public async Task<IActionResult> AddCategory([FromForm] AddCategoryFormData value)
    {
        var result = await Sender.Send(new CategoryAddQuery(value));
        return Ok(result);
    }

    [HttpPut("AddFieldForCategory")]
    public async Task<IActionResult> AddFieldForCategory([FromForm] AddFieldCategoryFormData value)
    {
        var result = await Sender.Send(new CategoryAddFieldQuery(value));
        return Ok(result);
    }

    [HttpDelete("RemoveFieldForCategory")]
    public async Task<IActionResult> RemoveFieldForCategory([FromForm] RemoveCategoryFieldFormData value)
    {
        var result = await Sender.Send(new CategoryRemoveFieldQuery(value));
        return Ok(result);
    }
}
