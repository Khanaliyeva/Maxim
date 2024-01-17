using Maxim.Areas.Manage.ViewModels;
using Maxim.DAL;
using Maxim.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Maxim.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var services = await _context.Services.ToListAsync();
            return View(services);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceVm serviceVm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Services service = new Services()
            {
                Title = serviceVm.Title,
                Description = serviceVm.Description,
                Icon = serviceVm.Icon
            };

            var result = await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();  
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Update(int id)
        {
            Services service =await  _context.Services.FindAsync(id);
            return View(service);
           

        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateServiceVm serviceVm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var oldservice=_context.Services.FirstOrDefault(s => s.Id == serviceVm.Id);
            oldservice.Title = serviceVm.Title;
            oldservice.Description = serviceVm.Description;
            oldservice.Icon = serviceVm.Icon;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var service = _context.Services.FirstOrDefault(p => p.Id == id);
            _context.Services.Remove(service);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
