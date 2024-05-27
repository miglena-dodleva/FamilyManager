using FamilyManager.Entities;

namespace FamilyManager.ViewModels.Families
{
    public class IndexVM
    {
        public List<string> MemberNames { get; set; } 
        public List<Family> Items { get; set; }
    }
}
