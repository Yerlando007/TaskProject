using TaskProject.Mediatr.CategoryMediatr.Query;

namespace TaskProject.Interfaces;

public interface ICategoryAdd
{
    Task<bool> AddCategory(CategoryAddQuery value);
    Task<bool> AddFieldCategory(CategoryAddFieldQuery value);
}
