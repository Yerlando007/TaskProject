namespace DataManager.Request;

public class AddGoodRequest
{
    public string GoodName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Field { get; set; } = null!;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}
