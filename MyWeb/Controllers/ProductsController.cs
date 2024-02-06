using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;
using MyWeb.Data.Services;
using MyWeb.Data.Static;
using MyWeb.Data.ViewModels;
using System.Linq;

namespace MyWeb.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProductsController : Controller
    {
        private readonly IProductsService _service;

        public ProductsController(IProductsService service)
        {
            this._service = service;
        }

        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            var allproducts = await _service.GetAllAsync(n => n.Category);
            return View(allproducts);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allproducts = await _service.GetAllAsync(n => n.Category);

            if(!string.IsNullOrEmpty(searchString)) 
            {
                var filteredResultNew = allproducts.Where(n => n.ProductName
                    .Contains(searchString, StringComparison.CurrentCultureIgnoreCase) 
                    || n.Category.CategoryName.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();
                return View("Index", filteredResultNew);
            }
            return View("Index", allproducts);
        }

        //Get: Products/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var productDetails = await _service.GetProductByIdAsync(id);
            return View(productDetails);
        }
        
        //GET: Products/Create
        public async Task<IActionResult> Create()
        {
            var productDropdownsData = await _service.GetNewProductDropdownsValues();

            ViewBag.Capacities = new SelectList(productDropdownsData.Capacities, "Capacity_Id", "Cap");
            ViewBag.Categories = new SelectList(productDropdownsData.Categories, "Id", "CategoryName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewProduct product)
        {
            if (!ModelState.IsValid)
            {
                var productDropdownsData = await _service.GetNewProductDropdownsValues();

                ViewBag.Capacities = new SelectList(productDropdownsData.Capacities,"Capacity_Id", "Cap");
                ViewBag.Categories = new SelectList(productDropdownsData.Categories,"Capacity_Id", "CategoryName");

                return View(product);
            }
            //List<int> selectedCapacityIds = product.CapacityIds;

            await _service.AddNewProductAsync(product);
            return RedirectToAction(nameof(Index));
        }

        //GET: Products/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var productDetails = await _service.GetProductByIdAsync(id);
            if (productDetails == null) return View("NotFound");

            var response = new NewProduct()
            {
                Product_Id = id,
                Sku_Code = productDetails.Sku_Code,
                ProductName = productDetails.ProductName,
                Price = productDetails.Price,
                ImageUrl = productDetails.ImageUrl,
                //Category = productDetails.Category,
                CategoryId = productDetails.Id,
                CapacityIds = productDetails.Products_Capacities.Select(n =>n.Capacity_Id).ToList(),
            };

            var productDropdownsData = await _service.GetNewProductDropdownsValues();
            ViewBag.Capacities = new SelectList(productDropdownsData.Capacities,"Capacity_Id", "Cap");
            ViewBag.Categories = new SelectList(productDropdownsData.Categories,"Id", "CategoryName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewProduct product)
        {
            if (id != product.Product_Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var productDropdownsData = await _service.GetNewProductDropdownsValues();

                ViewBag.Capacities = new SelectList(productDropdownsData.Capacities,"Capacity_Id", "Cap");
                ViewBag.Categories = new SelectList(productDropdownsData.Categories,"Id", "CategoryName");

                return View(product);
            }

            await _service.UpdateProductAsync(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
