namespace DataManager.Request;

public class AddFieldCategorRequest
{
    public int CategoryId { get; set; }
    public List<string> Field { get; set; } = null!;
}
