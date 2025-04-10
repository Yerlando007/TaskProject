namespace DataManager.EF;

public class Categories
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Goods> Goods { get; set;} = null!;
    public List<Field> Fields { get; set; } = null!;
    public List<FieldDescribe> FieldDescribes { get; set; } = null!;
}