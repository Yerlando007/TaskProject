using DataManager.EF;
using Microsoft.EntityFrameworkCore;

namespace DataManager.Base;

public class CategoryContext : DbContext
{
    public CategoryContext(DbContextOptions<CategoryContext> options) : base(options)
    {
    }
    
    public CategoryContext() { }

    public DbSet<Worker> Worker { get; set; }
    public DbSet<Position> Position { get; set; }
    public DbSet<CarNumber> CarNumber { get; set; }
}