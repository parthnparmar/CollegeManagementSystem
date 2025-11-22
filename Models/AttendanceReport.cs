namespace CollegeManagementSystem.Models
{
    public class AttendanceReport
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public int TotalStudents { get; set; }
        public double AveragePercent { get; set; }
        public int LowAttendanceCount { get; set; } // <75%
    }
}
