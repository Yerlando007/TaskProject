using DataManager.EF;

namespace TaskProject.Interfaces
{
    public interface IPositionService
    {
        Task AddPositions();
        Task<List<Position>> GetPositions();
    }
}
