using DataManager.Base;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.CategoryMediatr.Query;

public class CategoryRemoveFieldQuery : IRequest<Result<bool>>
{
    public CategoryRemoveFieldQuery(RemoveCategoryFieldFormData value)
    {
        CategoryId = value.CategoryId;
        Field = value.Field;
    }

    public int CategoryId { get; set; }
    public List<int> Field { get; set; } = null!;
}