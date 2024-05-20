using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class Task : BaseEntity
    {
        public int OwnerId { get; set; }
        
        public int AssigneeId { get; set; }
        
        public int ToDoListId { get; set; }
        
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime Deadline { get; set; }

        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }

        [ForeignKey("AssigneeId")]
        public virtual User Assignee { get; set; }

        [ForeignKey("ToDoListId")]
        public virtual ToDoList ToDoList { get; set; }
    }
}
