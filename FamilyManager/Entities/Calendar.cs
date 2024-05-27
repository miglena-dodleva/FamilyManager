using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class Calendar 
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }

        public virtual ICollection<CalendarToUser> CalendarToUsers { get; set; }
        public virtual ICollection<CalendarToFamily> CalendarToFamilies { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
