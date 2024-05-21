using FamilyManager.Entities;

namespace FamilyManager.ViewModels.Tasks
{
    public class IndexVM
    {
        public int Id { get; set; }

        public ToDoList ToDoList { get; set; }

        public List<DetailsVM> Items { get; set; }
        public FilterVM Filter { get; set; }
    }
}
