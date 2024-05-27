using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FamilyManager.ViewModels.SharedCalendars
{
    public class EditVM
    {
        public int Id { get; set; }

        [DisplayName("Calendar ID: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public int CalendarId { get; set; }

        [DisplayName("User ID: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public int UserId { get; set; }
    }
}
