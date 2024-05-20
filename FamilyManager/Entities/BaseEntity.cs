using System.ComponentModel.DataAnnotations;

namespace FamilyManager.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
