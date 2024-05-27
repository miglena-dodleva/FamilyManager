using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class CalendarToFamiliesRepository : BaseRepository<CalendarToFamily>
    {
        public CalendarToFamiliesRepository() : base() { }
        public CalendarToFamiliesRepository(UnitOfWork uow) : base(uow) { }
    }
}
