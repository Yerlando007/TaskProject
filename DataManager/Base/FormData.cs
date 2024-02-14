namespace DataManager.Base;

public class AddCategoryFormData
{
    public string CategoryName { get; set; } = null!;
    public List<string> Field { get; set; } = null!;
}

public class AddFieldCategoryFormData
{
    public int CategoryId { get; set; }
    public List<string> Field { get; set; } = null!;
}

public class RemoveCategoryFieldFormData
{
    public int CategoryId { get; set; }
    public List<int> Field { get; set; } = null!;
}

public class AddGoodFormData
{
    public string GoodName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Field { get; set; } = null!;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}