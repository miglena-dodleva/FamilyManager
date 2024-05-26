using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class ToDoList 
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

    }
}
