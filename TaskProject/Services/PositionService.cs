using DataManager.Base;
using DataManager.EF;
using Microsoft.EntityFrameworkCore;
using TaskProject.Interfaces;

namespace TaskProject.Services
{
    public class PositionService : IPositionService
    {
        public readonly CategoryContext _context;
        public PositionService(CategoryContext context) 
            => _context = context;

        public async Task AddPositions()
        {
            var listPosition = new List<Position>
            {
                new Position
                {
                    Id = 1,
                    Name = "Специлист"
                },
                new Position
                {
                    Id = 2,
                    Name = "Охраник"
                }
            };

            await _context.Position.AddRangeAsync(listPosition);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Position>> GetPositions()
        {
            var categoryList = await _context.Position.ToListAsync();

            return categoryList;
        }
    }
}
