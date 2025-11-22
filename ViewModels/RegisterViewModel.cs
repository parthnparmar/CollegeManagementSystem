using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public required string ConfirmPassword { get; set; }

        [Required]
        public required string FullName { get; set; }

        [Required]
        public required string Role { get; set; } // e.g., "Student", "Teacher", "Admin"
    }
}
