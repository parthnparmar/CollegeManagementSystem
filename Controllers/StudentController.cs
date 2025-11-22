using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CollegeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using CollegeManagementSystem.Models; // Make sure ApplicationUser is here

namespace CollegeManagementSystem.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Student Dashboard
        public async Task<IActionResult> Dashboard()
        {
            var username = User.Identity?.Name;

            if (string.IsNullOrEmpty(username))
                return Unauthorized();

            // Fetch student from Identity Users
            var student = await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == username);

            if (student == null)
                return NotFound();

            return View(student);
        }

        // Student Attendance
        public async Task<IActionResult> Attendance()
        {
            var username = User.Identity?.Name;

            if (string.IsNullOrEmpty(username))
                return Unauthorized();

            // Fetch student from Identity Users
            var student = await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == username);

            if (student == null)
                return NotFound();

            // Fetch attendance records
            var records = await _context.Attendances
                .Where(a => a.StudentId == student.Id)
                .Include(a => a.Course)
                .ToListAsync();

            return View(records);
        }

        // Student Profile
        public async Task<IActionResult> Profile()
        {
            var username = User.Identity?.Name;

            if (string.IsNullOrEmpty(username))
                return Unauthorized();

            var student = await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == username);

            if (student == null)
                return NotFound();

            return View(student);
        }
    }
}
