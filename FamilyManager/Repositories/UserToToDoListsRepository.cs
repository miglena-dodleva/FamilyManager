using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class UserToToDoListsRepository : BaseRepository<UserToToDoList>
    {
        public UserToToDoListsRepository() : base() { }
        public UserToToDoListsRepository(UnitOfWork uow) : base(uow) { }
    }
}
