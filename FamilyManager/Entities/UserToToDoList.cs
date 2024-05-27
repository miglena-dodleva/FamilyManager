using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class UserToToDoList
    {
        [Key]
        public int Id { get; set; }

        public int ToDoListId { get; set; }

        [ForeignKey("ToDoListId")]
        public virtual ToDoList ToDoList { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
