using FamilyManager.Enums;

namespace FamilyManager.ViewModels.Tasks
{
    public class DetailsVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime Deadline { get; set; }
        public string AssigneeName { get; set; }
        public string ToDoListName { get; set; }
        public string OwnerName { get; set; } 
    }
}
