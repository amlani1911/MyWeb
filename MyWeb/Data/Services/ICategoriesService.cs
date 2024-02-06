using MyWeb.Data.Base;
using MyWeb.Models;
using System.Collections.Generic;

namespace MyWeb.Data.Services
{
    public interface ICategoriesService : IEntityBaseRepository<Category>
    {
        //Task<IEnumerable<Category>> GetAllAsync();
        //Task<Category> GetByIdAsync(int id);
        //Task AddAsync(Category category);
        //Task<Category> UpdateAsync(int id, Category newcategory);
        //Task DeleteAsync(int id);
    }
}
