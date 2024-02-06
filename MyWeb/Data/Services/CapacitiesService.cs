using Microsoft.EntityFrameworkCore;
using MyWeb.Models;

namespace MyWeb.Data.Services
{
    public class CapacitiesService : ICapacitiesService
    {
        private readonly ApplicationDbContext _context;
        public CapacitiesService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Capacity capacity)
        {
            await _context.Capacities.AddAsync(capacity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Capacities.FirstOrDefaultAsync(n => n.Capacity_Id == id);
            _context.Capacities.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Capacity>> GetAllAsync()
        {
            var result = await _context.Capacities.ToListAsync();
            return result;
        }

        public async Task<Capacity> GetByIdAsync(int id)
        {
            var result = await _context.Capacities.FirstOrDefaultAsync(c => c.Capacity_Id == id);
            return result;
        }

        public async Task<Capacity> UpdateAsync(int id, Capacity newcapacity)
        {
            _context.Update(newcapacity);
            await _context.SaveChangesAsync();
            return newcapacity;
        }
    }
}
