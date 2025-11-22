using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CollegeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Dashboard()
        {
            ViewBag.StudentCount = await _context.Students.CountAsync();
            ViewBag.TeacherCount = await _context.Teachers.CountAsync();
            ViewBag.CourseCount = await _context.Courses.CountAsync();
            return View();
        }

        public IActionResult ManageUsers() => View();

        public IActionResult ManageCourses() => View();

        public IActionResult ManageDepartments() => View();
    }
}
