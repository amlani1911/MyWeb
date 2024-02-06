using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Data.Services;
using MyWeb.Models;
using Microsoft.AspNetCore.Authorization;
using MyWeb.Data.Static;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MyWeb.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class CategoryController : Controller
    {
        private readonly ICategoriesService _service;
        //private readonly Database _database;

        public CategoryController(ICategoriesService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var categories = await _service.GetAllAsync();
            return View(categories);
        }
        //public async Task<IActionResult> Index()
        //{
        //    using (var db = new Database("DefaultConnection", "System.Data.SqlClient"))
        //    {
        //        var categories = await db.QueryAsync<Category>("SELECT * FROM Categories");
        //        return View(categories);
        //    }
        //}

        // Get : Category/Create view
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("CategoryName,CategoryImageUrl")] Category category)
        {
            if(!ModelState.IsValid)
            {
                return View(category);
            }
            await _service.AddAsync(category);
            return RedirectToAction(nameof
                (Index));
        }

        //Get : Category/Details
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var categoriesDetails = await _service.GetByIdAsync(id);

            if (categoriesDetails == null) return View("NotFound");
            return View(categoriesDetails);
        }

        // Get : Category/Edit view
        public async Task<IActionResult> Edit(int id)
        {
            var categoriesDetails = await _service.GetByIdAsync(id);

            if (categoriesDetails == null) return View("NotFound");
            return View(categoriesDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryName,CategoryImageUrl")] Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            await _service.UpdateAsync(id, category);
            return RedirectToAction(nameof
                (Index));
        }

        // Get : Category/Delete view
        public async Task<IActionResult> Delete(int id)
        {
            var categoriesDetails = await _service.GetByIdAsync(id);

            if (categoriesDetails == null) return View("Not Found");
            return View(categoriesDetails);
        }

        [HttpPost , ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriesDetails =await _service.GetByIdAsync(id);
            if (categoriesDetails == null) return View("Not Found");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof
                (Index));
        }
    }
}