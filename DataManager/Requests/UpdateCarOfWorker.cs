namespace DataManager.Requests;

public class UpdateCarOfWorker
{
    public int WorkerId { get; set; }
    public string CarNumberOfWorker { get; set; } = null!;
}
