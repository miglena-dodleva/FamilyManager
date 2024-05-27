using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FamilyManager.ViewModels.SharedCalendars
{
    public class CreateVM
    {
        [DisplayName("Calendar ID: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public int CalendarId { get; set; }

        [DisplayName("User ID: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public int UserId { get; set; }
    }
}
