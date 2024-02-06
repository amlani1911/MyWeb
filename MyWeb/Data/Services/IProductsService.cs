using MyWeb.Data.ViewModels;
using MyWeb.Models;
using System.Linq.Expressions;

namespace MyWeb.Data.Services
{
    public interface IProductsService
    {
        Task<IEnumerable<Products>> GetAllAsync();
        Task<IEnumerable<Products>> GetAllAsync(params Expression<Func<Products, object>>[] includeProperties);
        Task<Products> GetByIdAsync(int id);
        Task<Products> GetByIdAsync(int id, params Expression<Func<Products, object>>[] includeProperties);
        Task<Products> GetProductByIdAsync(int id);
        Task<NewProductDropdowns> GetNewProductDropdownsValues();
        Task AddNewProductAsync(NewProduct data);
        Task UpdateProductAsync(NewProduct data);
    }
}
