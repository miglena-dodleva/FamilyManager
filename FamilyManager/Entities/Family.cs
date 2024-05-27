using System.ComponentModel.DataAnnotations;

namespace FamilyManager.Entities
{
    public class Family 
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        //public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<CalendarToFamily> CalendarToFamilies { get; set; }
    }
}
