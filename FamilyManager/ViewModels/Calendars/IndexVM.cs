using FamilyManager.Entities;

namespace FamilyManager.ViewModels.Calendars
{
    public class IndexVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnerName { get; set; }

        public List<Calendar> Items { get; set; }
    }
}
