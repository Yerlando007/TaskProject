using DataManager.EF;
using Microsoft.EntityFrameworkCore;
using TestMediatorApi.Models.EF;

namespace DataManager.Base;

public class CategoryContext : DbContext
{
    public CategoryContext(DbContextOptions<CategoryContext> options) : base(options)
    {
    }
    
    public CategoryContext() { }

    public DbSet<Category> Category { get; set; }
    public DbSet<Field> Field { get; set; }
    public DbSet<FieldDescribe> FieldDescribe { get; set; }
    public DbSet<Good> Good { get; set; }
}