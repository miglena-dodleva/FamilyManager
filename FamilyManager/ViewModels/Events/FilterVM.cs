using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FamilyManager.Entities;
using FamilyManager.Enums;

namespace FamilyManager.ViewModels.Events
{
    public class FilterVM
    {
        [DisplayName("Title: ")]
        public string Title { get; set; }

        [DisplayName("All Day Event: ")]
        public bool IsAFullDayEvent { get; set; }

        [DisplayName("Repeat Event: ")]
        public RepeatType IsRepeatEvent { get; set; }

        [DisplayName("Start Date: ")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
    }
}
