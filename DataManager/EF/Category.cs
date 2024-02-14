using DataManager.EF;

namespace DataManager.EF;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Good> Goods { get; set;} = null!;
    public List<Field> Fields { get; set; } = null!;
    public List<FieldDescribe> FieldDescribes { get; set; } = null!;
}