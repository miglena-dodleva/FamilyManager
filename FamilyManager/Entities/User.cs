using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Ensure to hash passwords before storage
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        public int? FamilyId { get; set; }
        
        [ForeignKey("FamilyId")]
        public virtual Family Family { get; set; }

        public virtual ICollection<SharedCalendar> SharedCalendars { get; set; }
        public virtual ICollection<UserToCalendar> UserToCalendars { get; set; }
        public virtual ICollection<UserToToDoList> UserToToDoLists { get; set; }
        public virtual ICollection<Task> OwnedTasks { get; set; } // Задачи, които потребителят е създал
        public virtual ICollection<Task> AssignedTasks { get; set; } // Задачи, възложени на потребителя

    }
}
