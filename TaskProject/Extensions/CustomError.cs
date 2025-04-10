using KDS.Primitives.FluentResult;

namespace TaskProject.Extensions;

public class CustomError : Error
{
    public CustomError(string code, string message)
     : base(code, message) { }

    public static CustomError Create(string code, string message) =>
        new(code, message);
}
