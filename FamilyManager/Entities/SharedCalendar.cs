using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class SharedCalendar : BaseEntity
    {
        public int CalendarId { get; set; }
        [ForeignKey("CalendarId")]
        public virtual Calendar Calendar { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
