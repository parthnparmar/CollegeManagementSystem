namespace CollegeManagementSystem.Models
{
    public class Teacher
    {
        public required string Id { get; set; }
        public required string Username { get; set; }
        public required string FullName { get; set; }
        public required string Department { get; set; }
        public required string Email { get; set; }
        public required string Subject { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
