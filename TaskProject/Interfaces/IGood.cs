using DataManager.EF;
using KDS.Primitives.FluentResult;
using TaskProject.Mediatr.Good.Command;

namespace TaskProject.Interfaces;

public interface IGood
{
    Task<Result> AddGoodItem(AddGoodCommand value);
    Task<Result<List<Goods>>> GetGoods();
}
