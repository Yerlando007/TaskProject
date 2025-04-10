using DataManager.Base;
using DataManager.EF;
using DataManager.Model;
using KDS.Primitives.FluentResult;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TaskProject.Extensions;
using TaskProject.Interfaces;
using TaskProject.Mediatr.Good.Command;

namespace TaskProject.Services;

public class GoodAddServices : IGoodAdd
{
    public readonly CategoryContext _context;
    public GoodAddServices(CategoryContext context) 
        => _context = context;

    public async Task<Result> AddGoodItem(AddGoodCommand value)
    {
        var goodDeserialize = JsonConvert.DeserializeObject<CategoryList>(value.CategoryFields);

        var fields = goodDeserialize!.CategoryFields.Select(field => new FieldDescribe
        {
            Description = field.CategoryDescription,
            CategoriesId = value.CategoryId,
            FieldId = field.FieldId
        }).ToList();

        await _context.Good.AddAsync(new Goods
        {
            Name = value.Name,
            FieldDescribe = fields,
            Description = value.Description,
            CategoriesId = value.CategoryId,
            Price = value.Price
        });

        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result<List<Goods>>> GetGoods()
    {
        var goods = await _context.Good.Include(g => g.FieldDescribe).ToListAsync();

        if (!goods.Any())
            return Result.Failure<List<Goods>>(CustomError.Create(ErrorCode.NotFoundError, "Товары не были найдены"));

        return Result.Success(goods);
    }
}
