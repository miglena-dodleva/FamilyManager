using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class SharedCalendarsRepository : BaseRepository<SharedCalendar>
    {
        public SharedCalendarsRepository() : base() { }
        public SharedCalendarsRepository(UnitOfWork uow) : base(uow) { }
    }
}
