using DataManager.EF;
using TaskProject.Mediatr.Worker.Command;

namespace TaskProject.Interfaces
{
    public interface IWorkerService
    {
        Task<bool> AddWorker(AddWorkerCommand value);
        Task<bool> DeleteWorker(DeleteWorkerCommand value);
        Task<bool> UpdateWorker(UpdateWorkerCommand value);
        Task<Worker> GetWorker(int workerId);
        Task<List<Worker>> GetWorkers();
    }
}
