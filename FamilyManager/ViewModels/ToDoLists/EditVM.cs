using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FamilyManager.ViewModels.ToDoLists
{
    public class EditVM : CreateVM
    {
        [Key]
        public int Id { get; set; }

        public int OwnerId { get; set; }
    }
}
