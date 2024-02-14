using DataManager.Base;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.CategoryMediatr.Query;

public class CategoryAddFieldQuery : IRequest<Result<bool>>
{
    public CategoryAddFieldQuery(AddFieldCategoryFormData value)
    {
        CategoryId = value.CategoryId;
        Field = value.Field;
    }

    public int CategoryId { get; set; }
    public List<string> Field { get; set; } = null!;
}