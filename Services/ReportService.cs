using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace CollegeManagementSystem.Services
{
    public class ReportService
    {
        private readonly ApplicationDbContext _context;

        public ReportService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Attendance> GetAttendanceReport()
        {
            return _context.Attendances.ToList();
        }
    }
}
