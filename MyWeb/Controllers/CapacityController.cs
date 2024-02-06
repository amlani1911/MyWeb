using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Data;
using MyWeb.Data.Services;
using MyWeb.Data.Static;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class CapacityController : Controller
    {
        private readonly ICapacitiesService _service;

        public CapacityController(ICapacitiesService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var capacities = await _service.GetAllAsync();
            return View(capacities);
        }

        //Get: Capacity/Create
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Cap")]Capacity capacity)
        {
            if(!ModelState.IsValid)
            {
                return View(capacity);
            }
            await _service.AddAsync(capacity);
            return RedirectToAction(nameof
                (Index));
        }

        //Get Capacity / Details
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var capacitiesDetails = await _service.GetByIdAsync(id);

            if (capacitiesDetails == null) return View("Not Found");
            return View(capacitiesDetails);
        }
        
        //Get: Capacity/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var capacitiesDetails = await _service.GetByIdAsync(id);

            if (capacitiesDetails == null) return View("Not Found");
            return View(capacitiesDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id , [Bind("Capacity_Id,Cap")]Capacity capacity)
        {
            if (!ModelState.IsValid)
            {
                return View(capacity);
            }
            await _service .UpdateAsync(id,capacity);
            return RedirectToAction(nameof
                (Index));
        }

        //Get: Capacity Delete
        public async Task<IActionResult> Delete(int id)
        {
            var capacitiesDetails = await _service.GetByIdAsync(id);
            if (capacitiesDetails == null) return View("Not Found");
            return View(capacitiesDetails);
        }

        [HttpPost , ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var capacitiesDetails = await _service.GetByIdAsync(id);
            if (capacitiesDetails == null) return View("Not Found");

            await _service .DeleteAsync(id);
            return RedirectToAction(nameof
                (Index));
        } 
    }
}
