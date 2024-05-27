using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class UserToFamiliesRepository : BaseRepository<CalendarToFamily>
    {
        public UserToFamiliesRepository() : base() { }
        public UserToFamiliesRepository(UnitOfWork uow) : base(uow) { }
    }
}
