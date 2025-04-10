namespace DataManager.EF;

public class Goods
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int CategoriesId { get; set; }
    public List<Field> Fields { get; set; } = null!;
    public List<FieldDescribe> FieldDescribe { get; set; } = null!;
}