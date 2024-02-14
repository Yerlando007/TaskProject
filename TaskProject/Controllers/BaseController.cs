using AutoMapper;
using DataManager.Base;
using KDS.Primitives.FluentResult;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace TaskProject.Controllers;

/// <summary>Базовый контроллер предоставляющий доступ к <see cref="ISender"/> и <see cref="IMapper"/></summary>
[ApiController]
[Produces("application/json")]
[ProducesResponseType(statusCode: (int)HttpStatusCode.ServiceUnavailable, type: typeof(ProblemDetails))]
[ProducesResponseType(statusCode: (int)HttpStatusCode.InternalServerError, type: typeof(ProblemDetails))]
public class BaseController : ControllerBase
{
    /// <summary>Получает доступ к интерфейсу медиатора</summary>
    protected ISender Sender =>
        HttpContext.RequestServices.GetRequiredService<ISender>() ?? throw new ArgumentNullException(nameof(ISender));

    /// <summary>Получает доступ к интерфейсу авто маппера</summary>
    protected IMapper Mapper =>
        HttpContext.RequestServices.GetRequiredService<IMapper>() ?? throw new ArgumentNullException(nameof(IMapper));

    /// <summary>
    /// Возвращает обработанную ошибку и подбирает статус код в зависимости от полученного кода ошибки
    /// </summary>
    protected ObjectResult ProblemResponse(Error error)
    {
        // TODO: Подумай как можно переделать 1 - выглядит некрасиво, 2 - разные результаты если ответ придет из exceptionHandler и basecontroller
        return error.Code switch
        {
            ErrorCode.DatabaseError => Problem(title: "Ошибка во время подключения к базе данных",
                detail: error.Message,
                statusCode: (int)HttpStatusCode.InternalServerError),
            ErrorCode.ExternalError => Problem(title: "Ошибка во время подключения к сервисной шине",
                detail: error.Message,
                statusCode: (int)HttpStatusCode.InternalServerError),
            ErrorCode.LogicConflict => Problem(title: "Конфликт логической зависимости",
                detail: error.Message,
                statusCode: (int)HttpStatusCode.BadRequest),
            ErrorCode.ParameterError => Problem(title: "Невалидный параметр",
                detail: error.Message,
                statusCode: (int)HttpStatusCode.BadRequest),
            ErrorCode.ConvertError => Problem(title: "Ошибка обработки данных",
            detail: error.Message,
            statusCode: (int)HttpStatusCode.InternalServerError),
            _ => Problem(title: "Необработанное исключение",
                detail: error.Message,
                statusCode: (int)HttpStatusCode.InternalServerError),
        };
    }
}