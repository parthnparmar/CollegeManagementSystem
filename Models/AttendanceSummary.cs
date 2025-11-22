using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public class AttendanceSummary
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        [Range(0, 100)]
        public double AttendancePercent { get; set; }

        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
