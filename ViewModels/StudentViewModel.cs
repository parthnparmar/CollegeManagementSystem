namespace CollegeManagementSystem.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string RollNo { get; set; }
        public required string Department { get; set; }
        public required string Email { get; set; }
        public double AttendancePercentage { get; set; }
    }
}
