namespace CollegeManagementSystem.Models
{
    public class Student
    {
        public required string Id { get; set; }
        public required string Username { get; set; }
        public required string FullName { get; set; }
        public string Name => FullName; // Alias for FullName
        public required string RollNumber { get; set; }
        public required string Department { get; set; }
        public required string PhotoPath { get; set; }
        public required string Year { get; set; }
        public required string Phone { get; set; }
        public string Email { get; set; } = string.Empty;
        public double AttendancePercent { get; set; } = 0.0;
        public int CourseId { get; set; }
        public required Course Course { get; set; }

        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}
