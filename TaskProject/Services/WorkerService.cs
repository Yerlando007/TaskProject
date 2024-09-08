using DataManager.Base;
using DataManager.EF;
using Microsoft.EntityFrameworkCore;
using TaskProject.Interfaces;
using TaskProject.Mediatr.Worker.Command;

namespace TaskProject.Services
{
    public class WorkerService : IWorkerService
    {
        public readonly CategoryContext _context;
        public WorkerService(CategoryContext context) 
            => _context = context;

        public async Task<bool> AddWorker(AddWorkerCommand value)
        {
            await _context.Worker.AddAsync(new Worker
            {
                FIO = value.FIO,
                Position = value.Position
            });

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteWorker(DeleteWorkerCommand value)
        {
            var worker = await _context.Worker.FirstOrDefaultAsync(r => r.Id == value.WorkerId);

            if (worker != null)
            {
                _context.Worker.Remove(worker);

                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateWorker(UpdateWorkerCommand value)
        {
            var worker = await _context.Worker.FirstOrDefaultAsync(r => r.Id == value.WorkerId);

            if (worker != null)
            {
                worker.FIO = value.Fio;

                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<Worker> GetWorker(int workerId)
        {
            var worker = await _context.Worker.FirstOrDefaultAsync(r => r.Id == workerId);

            if (worker != null)
                return worker;

            return new Worker();
        }

        public async Task<List<Worker>> GetWorkers()
        {
            var workers = await _context.Worker.ToListAsync();

            if (workers.Count > 0)
                return workers;

            return [];
        }
    }
}
