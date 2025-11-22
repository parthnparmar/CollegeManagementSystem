namespace CollegeManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public int Credits { get; set; }

        public required string TeacherId { get; set; }
        public required Teacher Teacher { get; set; }
        public string TeacherName => Teacher?.FullName ?? "N/A";

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
