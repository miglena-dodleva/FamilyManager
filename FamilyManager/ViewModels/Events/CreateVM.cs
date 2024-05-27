using FamilyManager.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FamilyManager.Enums;

namespace FamilyManager.ViewModels.Events
{
    public class CreateVM
    {
        [DisplayName("Title: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string Title { get; set; }

        [DisplayName("Description: ")]
        public string Description { get; set; }

        [DisplayName("Start Date: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [DisplayName("Start Time: ")]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [DisplayName("End Time: ")]
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }

        [DisplayName("All Day Event: ")]
        public bool IsAFullDayEvent { get; set; }

        [DisplayName("Repeat Event: ")]
        public RepeatType IsRepeatEvent { get; set; }

        [DisplayName("Theme Color: ")]
        public ThemeColor ThemeColor { get; set; }

        public int CalendarId { get; set; } 

        
    }
}
