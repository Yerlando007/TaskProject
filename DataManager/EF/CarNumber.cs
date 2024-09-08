public class CarNumber
{
    public int Id { get; set; }
    public int WhoAdded { get; set; }
    public string CarNumberOfWorker { get; set; } = null!;
    public int WorkerId { get; set; }
}