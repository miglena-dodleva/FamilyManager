using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsAFullDayEvent { get; set; }
        public ThemeColor ThemeColor { get; set; }
        public RepeatType IsRepeatEvent { get; set; }

        public int CalendarId { get; set; }
        
        [ForeignKey("CalendarId")]
        public virtual Calendar Calendar { get; set; }
    }

    public enum ThemeColor
    {
        Red,
        Blue,
        Green,
        Yellow,
        Orange,
        Purple,
        Pink,
        Gray,
        Black
    }

    public enum RepeatType
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }
}
