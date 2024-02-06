using Microsoft.EntityFrameworkCore;
using MyWeb.Data.ViewModels;
using MyWeb.Models;
using System.Linq.Expressions;

namespace MyWeb.Data.Services
{
    public class ProductsService : IProductsService
    {
        private readonly ApplicationDbContext _context;
        public ProductsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Products>> GetAllAsync()
        {
            var result = await _context.Products.ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Products>> GetAllAsync(params Expression<Func<Products, object>>[] includeProperties)
        {
            IQueryable<Products> query = _context.Set<Products>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();
        }

        public async Task<Products> GetByIdAsync(int id) => await _context.Set<Products>().FirstOrDefaultAsync(n =>n.Product_Id == id);

        public async Task<Products> GetByIdAsync(int id, params Expression<Func<Products, object>>[] includeProperties)
        {
            IQueryable<Products> query = _context.Set<Products>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.FirstOrDefaultAsync(n => n.Product_Id == id);
        }
        public async Task AddNewProductAsync(NewProduct data)
        {
            var newProduct = new Products()
            {
                Sku_Code = data.Sku_Code,
                ProductName = data.ProductName,
                Price = data.Price,
                ImageUrl = data.ImageUrl,
                Id = data.CategoryId
            };
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();

            //Add Product Capacities
            foreach(var capacity_id in  data.CapacityIds)
            {
                var newProductCapacity = new Products_Capacity()
                {
                    Sku_Code = newProduct.Sku_Code,
                    Capacity_Id = capacity_id
                };
                await _context.Products_Capacities.AddAsync(newProductCapacity);
            }
            await _context.SaveChangesAsync();
        }
        public async Task<Products> GetProductByIdAsync(int id)
        {
            var productDetails = await _context.Products
                .Include(c => c.Category)
                .Include(pc => pc.Products_Capacities).ThenInclude(c =>c.Capacity)
                .FirstOrDefaultAsync(n => n.Product_Id == id);
            return productDetails;
        }
            
        public async Task<NewProductDropdowns> GetNewProductDropdownsValues()
        {
            var response = new NewProductDropdowns()
            {
                Capacities = await _context.Capacities.OrderBy(n => n.Cap).ToListAsync(),
                Categories = await _context.Categories.OrderBy(n => n.CategoryName).ToListAsync()
            };
            return response;
        }


        public async Task UpdateProductAsync(NewProduct data)
        {
            var dbProduct = await _context.Products.FirstOrDefaultAsync(n => n.Product_Id == data.Product_Id);

            if(dbProduct != null)
            {
                dbProduct.Sku_Code = data.Sku_Code;
                dbProduct.ProductName = data.ProductName;
                dbProduct.Price = data.Price;
                dbProduct.ImageUrl = data.ImageUrl;
                //dbProduct.Category = data.CategoryIds;
                await _context.SaveChangesAsync();
            }
            //Removing existing Capacity
            var existingCapacityDb = _context.Products_Capacities.Where(n =>n.Sku_Code == data.Sku_Code).ToList();
            _context.Products_Capacities.RemoveRange(existingCapacityDb);
            await _context.SaveChangesAsync();

            //Add Product Capacities
            foreach (var capacity_id in data.CapacityIds)
            {
                var newProductCapacity = new Products_Capacity()
                {
                    Capacity_Id = capacity_id,  
                    Sku_Code = data.Sku_Code
                };
                await _context.Products_Capacities.AddAsync(newProductCapacity);
            }
            await _context.SaveChangesAsync();
        }
    }
}
