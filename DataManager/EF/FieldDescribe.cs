namespace DataManager.EF;

public class FieldDescribe
{
    public int Id { get; set; }
    public int GoodId { get; set; }
    public int CategoryId { get; set; }
    public string Description { get; set; } = null!;
}