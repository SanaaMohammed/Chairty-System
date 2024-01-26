using Microsoft.AspNetCore.Mvc;
using SDProject.Data;
using SDProject.Models;

namespace SDProject.Controllers.Inspector
{
    public class InspectorController : Controller
    {
        private readonly ApplicationDbContext _context;
        public InspectorController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Inspector");
        }
        public IActionResult Cases() 
        {
            var cases = _context.Cases.ToList();
            return View(cases);
        }
        public IActionResult Inspector()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Report()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Report(Report report)
        {
            if (ModelState.IsValid)
            {
                _context.Add(report);
                _context.SaveChanges();
                return RedirectToAction("Index", "Inspector");
            }
            return View(report);
        }
    }
}