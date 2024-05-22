using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class ToDoListsRepository : BaseRepository<ToDoList>
    {
        public ToDoListsRepository() : base() { }
        public ToDoListsRepository(UnitOfWork uow) : base(uow) { }
    }
}
