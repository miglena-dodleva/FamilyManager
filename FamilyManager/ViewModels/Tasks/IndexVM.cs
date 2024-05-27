using FamilyManager.Entities;
using Task = FamilyManager.Entities.Task;

namespace FamilyManager.ViewModels.Tasks
{
    public class IndexVM
    {
        public int Id { get; set; }

        public ToDoList ToDoList { get; set; }

        public List<Task> Items { get; set; }
        public FilterVM Filter { get; set; }
    }
}
