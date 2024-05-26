using FamilyManager.Enums;
using System.ComponentModel;

namespace FamilyManager.ViewModels.Tasks
{
    public class FilterVM
    {

        public Status Status { get; set; }
        public int? OwnerId { get; set; }
        public int? AssigneeId { get; set; }
    }
}
