using Microsoft.AspNetCore.Identity;

namespace CollegeManagementSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string FullName { get; set; }
    }
}
