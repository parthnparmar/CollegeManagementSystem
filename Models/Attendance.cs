namespace CollegeManagementSystem.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public required string StudentId { get; set; }
        public required Student Student { get; set; }
        public int CourseId { get; set; }
        public required Course Course { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; } // true = present, false = absent
    }
}
