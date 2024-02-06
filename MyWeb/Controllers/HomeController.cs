using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;
using MyWeb.Models;
using System.Diagnostics;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _logger;

        public HomeController(ApplicationDbContext logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var allproducts = _logger.Products.Include(n => n.Category).ToList();
            return View(allproducts);
            //return View();
        }
        public IActionResult About()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}