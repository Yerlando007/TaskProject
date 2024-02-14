using DataManager.Base;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.CategoryMediatr.Query;

public class CategoryAddQuery : IRequest<Result<bool>>
{
    public CategoryAddQuery(AddCategoryFormData value)
    {
        Name = value.CategoryName;
        Field = value.Field;
    }
    public string Name { get; set; }
    public List<string> Field { get; set; } = null!;
}
