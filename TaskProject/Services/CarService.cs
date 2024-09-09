using DataManager.Base;
using DataManager.Requests;
using Microsoft.EntityFrameworkCore;
using TaskProject.Interfaces;
using TaskProject.Mediatr.Car.Command;
using TaskProject.Mediatr.Worker.Command;

namespace TaskProject.Services
{
    public class CarService : ICarService
    {
        public readonly CategoryContext _context;
        public CarService(CategoryContext context) 
            => _context = context;

        public async Task<bool> AddCarToWorker(AddCarToWorkerCommand value)
        {
            await _context.CarNumber.AddAsync(new CarNumber
            {
                WorkerId = value.WorkerId,
                CarNumberOfWorker = value.CarNumberOfWorker,
                WhoAddedId = value.WorkerId
            });
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateCarOfWorker(UpdateWorkerCarCommand value)
        {
            var workerCar = await _context.CarNumber.FirstOrDefaultAsync(r => r.WorkerId == value.WorkerId);

            if (workerCar != null)
            {
                workerCar.CarNumberOfWorker = value.CarNumberOfWorker;

                await _context.SaveChangesAsync();

                return true;
            }

            return true;
        }

        public async Task<bool> DeleteCarOfWorker(DeleteWorkerCarCommand value)
        {
            var workerCar = await _context.CarNumber.FirstOrDefaultAsync(r => r.Id == value.Id);

            if (workerCar != null)
            {
                _context.CarNumber.Remove(workerCar);

                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<CarNumber> GetWorkerCar(int workerId)
        {
            var workerCar = await _context.CarNumber.FirstOrDefaultAsync(r => r.WorkerId == workerId);

            if (workerCar != null)
                return workerCar;

            return new CarNumber();
        }
    }
}
