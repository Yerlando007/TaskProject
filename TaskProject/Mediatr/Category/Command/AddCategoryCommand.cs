using DataManager.Base;
using DataManager.Request;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Category.Command;

public class AddCategoryCommand : IRequest<Result>
{
    public AddCategoryCommand(AddCategoryRequest value)
    {
        Name = value.CategoryName;
        Field = value.Field;
    }

    public string Name { get; set; }
    public List<string> Field { get; set; } = null!;
}