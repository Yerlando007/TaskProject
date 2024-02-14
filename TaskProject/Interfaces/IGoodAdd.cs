using DataManager.EF;
using TaskProject.Mediatr.Query;

namespace TaskProject.Interfaces;

public interface IGoodAdd
{
    Task<bool> AddGoodItem(GoodAddQuery value);
    Task<List<Good>> GetGoods(int fieldId);
}
