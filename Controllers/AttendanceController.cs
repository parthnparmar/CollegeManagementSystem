using Microsoft.AspNetCore.Mvc;
using CollegeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace CollegeManagementSystem.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AttendanceController(ApplicationDbContext context)
        {
            _context = context;
        }

        

        public async Task<IActionResult> Reports()
        {
            var summary = await _context.AttendanceSummaries.ToListAsync();
            return View(summary);
        }
    }
}
