using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FamilyManager.Enums;

namespace FamilyManager.ViewModels.Tasks
{
    public class CreateVM
    {
        [DisplayName("Title: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string Title { get; set; }

        [DisplayName("Description: ")]
        public string Description { get; set; }

        [DisplayName("Status: ")]
        public Status Status { get; set; }

        [DisplayName("Deadline: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        [DataType(DataType.DateTime)]
        public DateTime Deadline { get; set; }

        [DisplayName("Assignee: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public int AssigneeId { get; set; }

        public int ToDoListId { get; set; } // set automatically in the controller

        public int OwnerId { get; set; } // set automatically in the controller
    }
}
