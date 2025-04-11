using Microsoft.AspNetCore.Mvc;
using TaskProject.Mediatr.Category.Command;
using TaskProject.Mediatr.Category.Query;
using DataManager.Request;
using AutoMapper;
using MediatR;
using DataManager.Response;
using Microsoft.AspNetCore.Authorization;

namespace TaskProject.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class CategoryController : BaseController
{
    public CategoryController(ISender sender, IMapper mapper)
        : base(sender, mapper) { }

    [HttpPost("AddCategory")]
    public async Task<IActionResult> AddCategory([FromBody] AddCategoryRequest value)
    {
        var result = await _sender.Send(new AddCategoryCommand(value));

        return Ok(result);
    }

    [HttpPost("AddFieldForCategory")]
    public async Task<IActionResult> AddFieldForCategory([FromBody] AddFieldCategorRequest value)
    {
        var result = await _sender.Send(new AddCategoryFieldCommand(value));

        if (result.IsFailed)
            return BadRequest(ProblemResponse(result.Error));

        return Ok(result);
    }

    [HttpDelete("RemoveFieldForCategory")]
    public async Task<IActionResult> RemoveFieldForCategory([FromBody] RemoveCategoryFieldRequest value)
    {
        var result = await _sender.Send(new RemoveCategoryFieldCommand(value));

        if (result.IsFailed)
            return BadRequest(ProblemResponse(result.Error));

        return Ok(result);
    }

    [HttpGet("GetAllCategories")]
    public async Task<IActionResult> GetAllCategories()
    {
        var result = await _sender.Send(new AllCategoryQuery());

        if (result.IsFailed)
            return BadRequest(ProblemResponse(result.Error));

        return Ok(_mapper.Map<List<CategoryDto>>(result.Value));
    }
}