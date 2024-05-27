using FamilyManager.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FamilyManager.Enums;

namespace FamilyManager.ViewModels.Events
{
    public class EditVM : CreateVM
    {
        public int Id { get; set; }
    }
}
