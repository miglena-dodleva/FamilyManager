using FamilyManager.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FamilyManager.ViewModels.Tasks
{
    public class EditVM
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Title: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string Title { get; set; }

        [DisplayName("Description: ")]
        public string Description { get; set; }

        [DisplayName("Status: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public Status Status { get; set; }

        [DisplayName("Deadline: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        [DataType(DataType.DateTime)]
        public DateTime Deadline { get; set; }

        [DisplayName("Assignee: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public int AssigneeId { get; set; }

        [DisplayName("To-Do List: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public int ToDoListId { get; set; }

        public int OwnerId { get; set; } // This should not change after creation
    }
}
