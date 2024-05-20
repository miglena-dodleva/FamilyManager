using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class CalendarsRepository : BaseRepository<Calendar>
    {
        public CalendarsRepository() : base() {}
        public CalendarsRepository(UnitOfWork uow) : base(uow) {}
    }
}
