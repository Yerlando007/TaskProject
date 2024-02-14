using DataManager.Base;
using DataManager.EF;
using Microsoft.EntityFrameworkCore;
using TaskProject.Interfaces;
using TaskProject.Mediatr.CategoryMediatr.Query;

namespace TestMediatorApi.Services;

public class CategoryAddServices : ICategoryAdd
{
    public readonly CategoryContext _context;
    public CategoryAddServices(CategoryContext context) => _context = context;

    public async Task<bool> AddCategory(CategoryAddQuery value)
    {
        var fields = new List<Field>();
        foreach (var field in value.Field)
        {
            fields.Add(new Field
            {
                Name = field
            });
        }
        await _context.Category.AddAsync(new Category
        {
            Name = value.Name,
            Fields = fields
        });
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> AddFieldCategory(CategoryAddFieldQuery value)
    {
        var categoryList = await _context.Category.Include(r => r.Fields).ToListAsync();
        var category = categoryList.FirstOrDefault(r => r.Id == value.CategoryId);
        foreach (var field in value.Field)
        {
            category!.Fields.Add(new Field
            {
                Name = field,
                CategoryId = category.Id
            });
        }
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> RemoveFieldCategory(CategoryRemoveFieldQuery value)
    {
        var categoryList = await _context.Category.Include(r => r.Fields).ToListAsync();
        var category = categoryList.FirstOrDefault(r => r.Id == value.CategoryId);
        foreach (var field in value.Field)
        {
            category!.Fields.Remove(category.Fields.FirstOrDefault(r => r.Id == field)!);
        }
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Category>> GetFieldsCategory()
    {
        var categoryList = await _context.Category.Include(r => r.Fields).ToListAsync();
        return categoryList;
    }
}