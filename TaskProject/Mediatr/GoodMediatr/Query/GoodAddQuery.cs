using DataManager.Base;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Query;

public class GoodAddQuery : IRequest<Result<bool>>
{
    public GoodAddQuery(AddGoodFormData value)
    {
        Name = value.GoodName;
        CategoryFields = value.Field;
        Description = value.Description;
        CategoryId = value.CategoryId;
        Price = value.Price;
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public string CategoryFields { get; set; } = null!;
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
}
