using System;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public class AttendanceRecord
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public string CourseName { get; set; } = string.Empty;
        public string Status { get; set; } = "Present"; // Present / Absent
        public DateTime Date { get; set; } = DateTime.Now;

        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
