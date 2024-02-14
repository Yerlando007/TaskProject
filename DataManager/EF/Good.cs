namespace DataManager.EF;

public class Good
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Decription { get; set; } = null!;

    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public List<FieldDescribe> FieldDescribe { get; set; } = null!;
}