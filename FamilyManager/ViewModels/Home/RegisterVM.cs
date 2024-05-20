using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FamilyManager.ViewModels.Home
{
    public class RegisterVM
    {
        [DisplayName("FirstName: ")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 50 characters.")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("LastName: ")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last Name must be between 2 and 50 characters.")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Username: ")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Username must be between 5 and 50 characters.")]
        [Required]
        public string Username { get; set; }

        [DisplayName("Password: ")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters.")]
        [Required]
        public string Password { get; set; }

        [DisplayName("Confirm Password: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Confirm Password must be between 6 and 100 characters.")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Email: ")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required] 
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "Phone Number must be between 10 and 15 characters.")]
        [Required]
        public string PhoneNumber { get; set; }

        [DisplayName("Family ID: ")]
        public int? FamilyId { get; set; }
    }
}
