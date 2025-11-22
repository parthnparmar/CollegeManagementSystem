using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagementSystem.Models
{
    public static class RoleSeedData
    {
        public static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Teacher", NormalizedName = "TEACHER" },
                new IdentityRole { Name = "Student", NormalizedName = "STUDENT" }
            );
        }
    }
}
