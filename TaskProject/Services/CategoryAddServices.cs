using DataManager.Base;
using DataManager.EF;
using KDS.Primitives.FluentResult;
using Microsoft.EntityFrameworkCore;
using TaskProject.Extensions;
using TaskProject.Interfaces;
using TaskProject.Mediatr.Category.Command;

namespace TaskProject.Services;

public class CategoryAddServices : ICategoryAdd
{
    public readonly CategoryContext _context;
    public CategoryAddServices(CategoryContext context)
        => _context = context;

    public async Task AddCategory(AddCategoryCommand value)
    {
        await _context.Category.AddAsync(new Categories
        {
            Name = value.Name,
            Fields = [.. value.Field.Select(fieldName => new Field
            {
                Name = fieldName
            })]
        });

        await _context.SaveChangesAsync();
    }

    public async Task<Result> AddFieldCategory(AddCategoryFieldCommand value)
    {
        var category = await _context.Category
            .Include(c => c.Fields)
            .FirstOrDefaultAsync(c => c.Id == value.CategoryId);

        if (category == null)
            return Result.Failure(CustomError.Create(ErrorCode.NotFoundError, "Категория не была найдена"));

        foreach (var fieldName in value.Field.Distinct())
            if (!category.Fields.Any(f => f.Name == fieldName))
                category.Fields.Add(new Field { Name = fieldName });

        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result> RemoveFieldCategory(RemoveCategoryFieldCommand value)
    {
        var category = await _context.Category
            .Include(c => c.Fields)
            .FirstOrDefaultAsync(c => c.Id == value.CategoryId);

        if (category == null)
            return Result.Failure(CustomError.Create(ErrorCode.NotFoundError, "Категория не была найдена"));

        foreach (var fieldId in value.Field)
        {
            var fieldToRemove = category.Fields.FirstOrDefault(f => f.Id == fieldId);
            if (fieldToRemove != null)
                category.Fields.Remove(fieldToRemove);
        }

        await _context.SaveChangesAsync();

        return Result.Success();

    }

    public async Task<Result<List<Categories>>> GetFieldsCategory()
    {
        var categories = await _context.Category.Include(c => c.Fields).ToListAsync();

        if (!categories.Any())
            return Result.Failure<List<Categories>>(CustomError.Create(ErrorCode.NotFoundError, "Список категорий пуст"));

        return Result.Success(categories);
    }
}