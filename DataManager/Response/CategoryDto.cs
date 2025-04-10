using DataManager.EF;

namespace DataManager.Response;

public class CategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<GoodsDto> Goods { get; set; } = null!;
    public List<FieldDto> Fields { get; set; } = null!;
    public List<FieldDescribeDto> FieldDescribes { get; set; } = null!;
}
