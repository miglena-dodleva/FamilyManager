using FamilyManager.Entities;

namespace FamilyManager.ViewModels.ToDoLists
{
    public class IndexVM
    {
        public List<DetailsVM> Items { get; set; }

        public FilterVM Filter {  get; set; }
    }
}
