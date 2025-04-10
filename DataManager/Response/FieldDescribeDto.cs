namespace DataManager.Response;

public class FieldDescribeDto
{
    public int Id { get; set; }
    public int GoodId { get; set; }
    public int CategoriesId { get; set; }
    public int FieldId { get; set; }
    public string Description { get; set; } = null!;
}
