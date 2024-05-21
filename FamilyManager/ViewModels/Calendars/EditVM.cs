using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FamilyManager.ViewModels.Calendars
{
    public class EditVM
    {

        public int Id { get; set; }

        [DisplayName("Name: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        public string Name { get; set; }

        public int OwnerId { get; set; }
    }
}
