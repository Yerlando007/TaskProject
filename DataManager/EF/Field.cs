namespace DataManager.EF;

public class Field
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int CategoriesId { get; set; }
    public List<FieldDescribe> FieldDescribe { get; set; } = null!;
}