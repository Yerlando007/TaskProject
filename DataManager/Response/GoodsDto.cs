namespace DataManager.Response;

public class GoodsDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public List<FieldDto> Fields { get; set; } = null!;
    public List<FieldDescribeDto> FieldDescribe { get; set; } = null!;
}