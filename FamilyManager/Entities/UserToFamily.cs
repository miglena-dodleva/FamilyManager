using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class UserToFamily
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int FamilyId { get; set; }

        [ForeignKey("FamilyId")]
        public virtual Family Family { get; set; }
    }
}
