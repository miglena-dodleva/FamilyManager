using FamilyManager.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class Task 
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Status Status { get; set; }

        public DateTime Deadline { get; set; }
        
        public int OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }

        public int AssigneeId { get; set; }
        [ForeignKey("AssigneeId")]
        public virtual User Assignee { get; set; }

        public int ToDoListId { get; set; }
        [ForeignKey("ToDoListId")]
        public virtual ToDoList ToDoList { get; set; }
    }
}
