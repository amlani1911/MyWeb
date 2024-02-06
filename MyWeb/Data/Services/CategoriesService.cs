using Microsoft.EntityFrameworkCore;
using MyWeb.Data.Base;
using MyWeb.Models;

namespace MyWeb.Data.Services
{
    public class CategoriesService : EntityBaseRepository<Category> ,ICategoriesService
    {

        public CategoriesService(ApplicationDbContext context) : base(context) { }
        //{
        //    _context = context;
        //}
        //public async Task AddAsync(Category category)
        //{
        //    await _context.Categories.AddAsync(category);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var result = await _context.Categories.FirstOrDefaultAsync(n => n.Id == id);
        //    _context.Categories.Remove(result);
        //    _context.SaveChanges();
        //}

        //public async Task<IEnumerable<Category>> GetAllAsync()
        //{
        //    var result = await _context.Categories.ToListAsync();
        //    return result;
        //}

        //public async Task<Category> GetByIdAsync(int id)
        //{
        //    var result = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        //    return result;
        //}

        //public async Task<Category> UpdateAsync(int id, Category newcategory)
        //{
        //    _context.Update(newcategory);
        //    await _context.SaveChangesAsync();
        //    return newcategory;
        //}
    }
}
