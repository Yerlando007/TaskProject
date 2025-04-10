using DataManager.EF;
using KDS.Primitives.FluentResult;
using TaskProject.Mediatr.Category.Command;

namespace TaskProject.Interfaces;

public interface ICategoryAdd
{
    Task AddCategory(AddCategoryCommand value);
    Task<Result> AddFieldCategory(AddCategoryFieldCommand value);
    Task<Result> RemoveFieldCategory(RemoveCategoryFieldCommand value);
    Task<Result<List<Categories>>> GetFieldsCategory();
}