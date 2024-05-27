using FamilyManager.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FamilyManager.ViewModels.Tasks
{
    public class EditVM : CreateVM
    {
        public int Id { get; set; }
    }
}
