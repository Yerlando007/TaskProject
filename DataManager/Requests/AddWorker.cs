namespace DataManager.Requests;

public class AddWorker
{
    public string FIO { get; set; } = null!;
    public int Position { get; set; }
}