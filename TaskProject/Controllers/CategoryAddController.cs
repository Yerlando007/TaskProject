using Microsoft.AspNetCore.Mvc;
using TaskProject.Mediatr.Category.Command;
using TaskProject.Mediatr.Category.Query;
using DataManager.Request;
using AutoMapper;
using MediatR;
using DataManager.Response;

namespace TaskProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryAddController : BaseController
{
    public CategoryAddController(ISender sender, IMapper mapper)
        : base(sender, mapper) { }

    [HttpPost("AddCategory")]
    public async Task<IActionResult> AddCategory([FromForm] AddCategoryRequest value)
    {
        var result = await _sender.Send(new AddCategoryCommand(value));

        return Ok(result);
    }

    [HttpPost("AddFieldForCategory")]
    public async Task<IActionResult> AddFieldForCategory([FromForm] AddFieldCategorRequest value)
    {
        var result = await _sender.Send(new AddCategoryFieldCommand(value));

        if (result.IsFailed)
            return BadRequest(ProblemResponse(result.Error));
                
        return Ok(result);
    }

    [HttpDelete("RemoveFieldForCategory")]
    public async Task<IActionResult> RemoveFieldForCategory([FromForm] RemoveCategoryFieldRequest value)
    {
        var result = await _sender.Send(new RemoveCategoryFieldCommand(value));

        if (result.IsFailed)
            return BadRequest(ProblemResponse(result.Error));

        return Ok(result);
    }

    [HttpGet("GetAllCategory")]
    public async Task<IActionResult> GetAllCategory()
    {
        var result = await _sender.Send(new AllCategoryQuery());

        if (result.IsFailed)
            return BadRequest(ProblemResponse(result.Error));

        return Ok(_mapper.Map<List<CategoryDto>>(result.Value));
    }
}