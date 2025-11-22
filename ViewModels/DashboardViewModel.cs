using System.Collections.Generic;

namespace CollegeManagementSystem.ViewModels
{
    public class DashboardViewModel
    {
        public required string UserName { get; set; }
        public int TotalCourses { get; set; }
        public double AttendancePercentage { get; set; }
        public required List<string> RecentActivities { get; set; }
    }
}
