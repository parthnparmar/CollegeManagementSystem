using CollegeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagementSystem.Services
{
    public class AnalyticsService
    {
        private readonly ApplicationDbContext _context;
        public AnalyticsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, double>> GetAttendanceStatsAsync()
        {
            var stats = await _context.Attendances
                .GroupBy(a => a.Course.Name)
                .Select(g => new { Course = g.Key, Percent = g.Average(x => x.Status ? 100 : 0) })
                .ToDictionaryAsync(x => x.Course, x => x.Percent);
            return stats;
        }

        public async Task<List<object>> GetAttendanceChartDataAsync()
        {
            return await _context.Attendances
                .GroupBy(a => a.Course.Name)
                .Select(g => new { Course = g.Key, Attendance = g.Count(a => a.Status) })
                .Cast<object>()
                .ToListAsync();
        }
    }
}
