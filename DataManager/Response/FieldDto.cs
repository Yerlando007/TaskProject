using DataManager.EF;

namespace DataManager.Response;

public class FieldDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int CategoriesId { get; set; }
    public List<FieldDescribeDto> FieldDescribe { get; set; } = null!;
}
