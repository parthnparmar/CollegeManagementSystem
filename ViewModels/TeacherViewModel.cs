namespace CollegeManagementSystem.ViewModels
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Department { get; set; }
        public required string Email { get; set; }
        public required string Subject { get; set; }
    }
}
