namespace DataManager.Model;

public class XMLModel
{
    public int CategoryId { get; set; }
    public int FieldId { get; set; }
    public string CategoryDescription { get; set; } = null!;
}

public class CategoryList
{
    public List<XMLModel> CategoryFields { get; set; } = null!;
}