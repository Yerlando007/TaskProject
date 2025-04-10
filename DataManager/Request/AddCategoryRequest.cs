namespace DataManager.Request;

public class AddCategoryRequest
{
    public string CategoryName { get; set; } = null!;
    public List<string> Field { get; set; } = null!;
}
