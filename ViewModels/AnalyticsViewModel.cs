using System.Collections.Generic;

namespace CollegeManagementSystem.ViewModels
{
    public class AnalyticsViewModel
    {
        public int TotalStudents { get; set; }
        public int TotalTeachers { get; set; }
        public int TotalDepartments { get; set; }
        public int TotalCourses { get; set; }

        public required Dictionary<string, double> AttendanceChart { get; set; }
    }
}
