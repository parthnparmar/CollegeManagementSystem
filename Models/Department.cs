namespace CollegeManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
