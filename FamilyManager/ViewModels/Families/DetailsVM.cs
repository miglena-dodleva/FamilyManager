using System.ComponentModel.DataAnnotations;

namespace FamilyManager.ViewModels.Families
{
    public class DetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> MemberNames { get; set; } // List of family member names   
    }
}
