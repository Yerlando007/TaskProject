using AutoMapper;
using KDS.Primitives.FluentResult;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TaskProject.Extensions;

namespace TaskProject.Controllers;

[ApiController]
[Produces("application/json")]
[ProducesResponseType(statusCode: (int)HttpStatusCode.ServiceUnavailable, type: typeof(ProblemDetails))]
[ProducesResponseType(statusCode: (int)HttpStatusCode.InternalServerError, type: typeof(ProblemDetails))]
public class BaseController : ControllerBase
{
    protected readonly ISender _sender;
    protected readonly IMapper _mapper;

    // Конструктор для инъекции зависимостей
    public BaseController(ISender sender, IMapper mapper)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    protected ObjectResult ProblemResponse(Error error)
    {
        var problemDetails = error.ToProblemDetails();
        return Problem(title: problemDetails.Title, detail: problemDetails.Detail, statusCode: problemDetails.Status);
    }      
}