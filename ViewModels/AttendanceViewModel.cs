using System;
using System.Collections.Generic;

namespace CollegeManagementSystem.ViewModels
{
    public class AttendanceViewModel
    {
        public int StudentId { get; set; }
        public required string StudentName { get; set; }
        public required string CourseName { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }

        public List<AttendanceSummaryItem> MonthlySummary { get; set; } = new();
    }

    public class AttendanceSummaryItem
    {
        public required string Month { get; set; }
        public double AttendancePercentage { get; set; }
    }
}
