using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Controllers.Ajax
{
    public class AjaxController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AjaxController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Categories()
        {
            var allcategories = _context.Categories.ToList();
            return new JsonResult(allcategories);
        }

        [HttpPost]
        public JsonResult AddCategory([FromBody]Category category)
        {
            var cat = new Category()
            {
                CategoryName = category.CategoryName,
                CategoryImageUrl = category.CategoryImageUrl
            };
            _context.Categories.Add(cat);
            _context.SaveChanges();
            return new JsonResult("Data is saved");
        }
        public JsonResult Delete(int id)
        {
            var data = _context.Categories.Where(c =>c.Id == id).SingleOrDefault();
            _context.Categories.Remove(data);
            _context.SaveChanges();
            return new JsonResult("Data is deleted");
        }

        public JsonResult Edit(int id)
            {
            var data = _context.Categories.Where(c =>c.Id == id).SingleOrDefault();
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Update([FromBody]Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return new JsonResult("Record Updated");
        }
    }
}
