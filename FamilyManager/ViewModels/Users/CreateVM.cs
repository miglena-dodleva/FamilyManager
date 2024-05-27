using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FamilyManager.Enums;

namespace FamilyManager.ViewModels.Users
{
    public class CreateVM
    {
        [DisplayName("First Name: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string FirstName { get; set; }

        [DisplayName("Last Name: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string LastName { get; set; }

        [DisplayName("Username: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string Username { get; set; }

        [DisplayName("Password: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string Password { get; set; }

        [DisplayName("Email: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [DisplayName("Phone Number: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        [Phone(ErrorMessage = "Invalid Phone Number")] 
        public string PhoneNumber { get; set; }

        [DisplayName("Family ID: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public int? FamilyId { get; set; }

        [Display(Name = "Family Role")]
        public Role FamilyRole { get; set; }
    }
}
