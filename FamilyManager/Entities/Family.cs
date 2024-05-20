namespace FamilyManager.Entities
{
    public class Family : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
