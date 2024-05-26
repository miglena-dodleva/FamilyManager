using FamilyManager.Entities;
using FamilyManager.Enums;

namespace FamilyManager.ViewModels.Events
{
    public class DetailsVM
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public bool IsAFullDayEvent { get; set; }

        public RepeatType IsRepeatEvent { get; set; }
        
        public ThemeColor ThemeColor { get; set; }
        
        public string CalendarName { get; set; }
    }
}
