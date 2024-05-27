using FamilyManager.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Role FamilyRole { get; set; }

        public int? FamilyId { get; set; }
        
        [ForeignKey("FamilyId")]
        public virtual Family Family { get; set; }

        public virtual ICollection<SharedCalendar> SharedCalendars { get; set; }
        public virtual ICollection<Calendar> Calendars { get; set; }
        public virtual ICollection<ToDoList> ToDoLists { get; set; }
        public virtual ICollection<Task> OwnedTasks { get; set; } 
        public virtual ICollection<Task> AssignedTasks { get; set; } 

    }
}
