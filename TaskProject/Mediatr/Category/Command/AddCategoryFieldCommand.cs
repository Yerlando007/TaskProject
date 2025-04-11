using DataManager.Request;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Category.Command;

public class AddCategoryFieldCommand : IRequest<Result>
{
    public AddCategoryFieldCommand(AddFieldCategorRequest value)
    {
        CategoryId = value.CategoryId;
        Field = value.Field;
    }

    public int CategoryId { get; set; }
    public List<string> Field { get; set; } = null!;
}