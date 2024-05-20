using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class EventsRepository : BaseRepository<Event>
    {
        public EventsRepository() : base() { }
        public EventsRepository(UnitOfWork uow) : base(uow) { }
    }
}
