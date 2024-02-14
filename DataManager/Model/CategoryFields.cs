namespace DataManager.Model;

public class CategoryFields
{
    public int CategoryId { get; set; }
    public int FieldId { get; set; }
    public string CategoryDescription { get; set; } = null!;
}

public class CategoryList
{
    public List<CategoryFields> CategoryFields { get; set; } = null!;
}
