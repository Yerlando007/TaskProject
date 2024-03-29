﻿using DataManager.Base;
using DataManager.EF;
using DataManager.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TaskProject.Interfaces;
using TaskProject.Mediatr.Query;

namespace TestMediatorApi.Services;

public class GoodAddServices : IGoodAdd
{
    public readonly CategoryContext _context;
    public GoodAddServices(CategoryContext context) => _context = context;

    public async Task<bool> AddGoodItem(GoodAddQuery value)
    {
        var fields = new List<FieldDescribe>();
        var goodDeserialize = JsonConvert.DeserializeObject<CategoryList>(value.CategoryFields);       
        foreach (var field in goodDeserialize!.CategoryFields)
        {
            fields.Add(new FieldDescribe
            {
                Description = field.CategoryDescription,
                CategoryId = value.CategoryId,
                FieldId = field.FieldId
            });
        }
        await _context.Good.AddAsync(new Good
        {
            Name = value.Name,
            FieldDescribe = fields,
            Decription = value.Description,
            CategoryId = value.CategoryId,
            Price = value.Price
        });
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Good>> GetGoods(int fieldId)
    {
        var goodList = await _context.Good.Include(r => r.FieldDescribe).ToListAsync();
        return goodList;
    }
}
