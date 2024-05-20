using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class UserToToDoList : BaseEntity
    {
        public int UserId { get; set; }
        public int ToDoListId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("ToDoListId")]
        public virtual ToDoList ToDoList { get; set; }
    }
}
