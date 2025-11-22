using Microsoft.AspNetCore.Mvc;
using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var depts = await _context.Departments.ToListAsync();
            return View(depts);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(Department dept)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(dept);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dept);
        }
    }
}
