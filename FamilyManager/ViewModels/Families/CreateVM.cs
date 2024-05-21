using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FamilyManager.ViewModels.Families
{
    public class CreateVM
    {
        [DisplayName("Name: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        public string Name { get; set; }
    }
}
