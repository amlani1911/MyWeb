using MyWeb.Data.Base;
using MyWeb.Models;

namespace MyWeb.Data.Services
{
    public interface ICapacitiesService
    {
        Task<IEnumerable<Capacity>> GetAllAsync();
        Task<Capacity> GetByIdAsync(int id);
        Task AddAsync(Capacity capacity);
        Task<Capacity> UpdateAsync(int id, Capacity newcapacity);
        Task DeleteAsync(int id);
    }
}
