using DataManager.Request;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Category.Command;

public class RemoveCategoryFieldCommand : IRequest<Result>
{
    public RemoveCategoryFieldCommand(RemoveCategoryFieldRequest value)
    {
        CategoryId = value.CategoryId;
        Field = value.Field;
    }

    public int CategoryId { get; set; }
    public List<int> Field { get; set; } = null!;
}