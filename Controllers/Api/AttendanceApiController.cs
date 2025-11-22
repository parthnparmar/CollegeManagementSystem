using Microsoft.AspNetCore.Mvc;
using CollegeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AttendanceApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("summary")]
        public async Task<IActionResult> GetAttendanceSummary()
        {
            var data = await _context.AttendanceSummaries
    .Select(x => new
    {
        x.StudentId,
        x.CourseId,
        x.AttendancePercent  // <- use the correct property name
    }).ToListAsync();

            return Ok(data);
        }
    }
}
