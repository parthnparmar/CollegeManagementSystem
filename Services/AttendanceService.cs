using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagementSystem.Services
{
    public class AttendanceService
    {
        private readonly ApplicationDbContext _context;

        public AttendanceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Attendance>> GetAttendanceByCourseAsync(int courseId)
        {
            return await _context.Attendances
                .Include(a => a.Student)
                .Where(a => a.CourseId == courseId)
                .ToListAsync();
        }
    }
}
