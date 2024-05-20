using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class Calendar : BaseEntity
    {
        public string Name { get; set; }
        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }

        public virtual ICollection<SharedCalendar> SharedCalendars { get; set; }
        public virtual ICollection<UserToCalendar> UserToCalendars { get; set; }
    }
}
