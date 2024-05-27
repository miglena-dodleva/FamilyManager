using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FamilyManager.ViewModels.Families
{
    public class EditVM : CreateVM
    {
        public int Id { get; set; }
    }
}
