namespace DataManager.Requests;

public class AddCarToWorker
{
    public int WhoAddedId { get; set; }
    public string CarNumberOfWorker { get; set; } = null!;
    public int WorkerId { get; set; }
}
