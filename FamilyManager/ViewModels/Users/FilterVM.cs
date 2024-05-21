using System.ComponentModel;

namespace FamilyManager.ViewModels.Users
{
    public class FilterVM
    {
        [DisplayName("Search Term: ")]
        public string SearchTerm { get; set; }
    }
}
