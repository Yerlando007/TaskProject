using DataManager.Base;
using KDS.Primitives.FluentResult;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace TaskProject.Extensions;

public static class ErrorExtensions
{
    public static ProblemDetails ToProblemDetails(this Error error)
    {
        var (title, statusCode) = error.Code switch
        {
            ErrorCode.DatabaseError => ("Ошибка во время подключения к базе данных", HttpStatusCode.InternalServerError),
            ErrorCode.ExternalError => ("Ошибка во время подключения к сервисной шине", HttpStatusCode.InternalServerError),
            ErrorCode.LogicConflict => ("Конфликт логической зависимости", HttpStatusCode.BadRequest),
            ErrorCode.ParameterError => ("Невалидный параметр", HttpStatusCode.BadRequest),
            ErrorCode.ConvertError => ("Ошибка обработки данных", HttpStatusCode.InternalServerError),
            ErrorCode.NotFoundError => ("Не найдено", HttpStatusCode.NotFound),
            ErrorCode.NetworkError => ("Ошибка сети", HttpStatusCode.ServiceUnavailable),
            ErrorCode.UnexpectedError => ("Непредвиденная ошибка", HttpStatusCode.InternalServerError),
            _ => ("Необработанное исключение", HttpStatusCode.InternalServerError),
        };

        return new ProblemDetails
        {
            Title = title,
            Detail = error.Message,
            Status = (int)statusCode
        };
    }
}