using DataManager.Base;
using DataManager.Request;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Good.Command;

public class AddGoodCommand : IRequest<Result>
{
    public AddGoodCommand(AddGoodRequest value)
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
