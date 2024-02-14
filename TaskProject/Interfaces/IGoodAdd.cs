using TaskProject.Mediatr.Query;

namespace TaskProject.Interfaces;

public interface IGoodAdd
{
    Task<bool> AddGoodItem(GoodAddQuery value);
}
