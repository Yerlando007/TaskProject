using DataManager.Requests;
using TaskProject.Mediatr.Car.Command;
using TaskProject.Mediatr.Worker.Command;

namespace TaskProject.Interfaces
{
    public interface ICarService
    {
        Task<bool> AddCarToWorker(AddCarToWorkerCommand value);
        Task<bool> UpdateCarOfWorker(UpdateWorkerCarCommand value);
        Task<bool> DeleteCarOfWorker(DeleteWorkerCarCommand value);
        Task<CarNumber> GetWorkerCar(int workerId);
    }
}
