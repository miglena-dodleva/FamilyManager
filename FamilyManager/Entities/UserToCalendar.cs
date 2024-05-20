using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class UserToCalendar : BaseEntity
    {
        public int UserId { get; set; }
        public int CalendarId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("CalendarId")]
        public virtual Calendar Calendar { get; set; }
    }
}
