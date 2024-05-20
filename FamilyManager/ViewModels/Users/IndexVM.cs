using FamilyManager.Entities;

namespace FamilyManager.ViewModels.Users
{
    public class IndexVM
    {
        public List<User> Items { get; set; }
        public FilterVM Filter { get; set; }
        
    }
}
