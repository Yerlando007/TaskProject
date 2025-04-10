namespace DataManager.Request;

public class RemoveCategoryFieldRequest
{
    public int CategoryId { get; set; }
    public List<int> Field { get; set; } = null!;
}
