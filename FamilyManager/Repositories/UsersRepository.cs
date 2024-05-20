using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class UsersRepository : BaseRepository<User>
    {
        public UsersRepository() : base() { }
        public UsersRepository(UnitOfWork uow) : base(uow) { }
        //public void SaveChanges() { }
    }

}
