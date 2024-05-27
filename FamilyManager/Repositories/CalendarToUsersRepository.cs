using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class CalendarToUsersRepository : BaseRepository<CalendarToUser>
    {
        public CalendarToUsersRepository() : base() { }
        public CalendarToUsersRepository(UnitOfWork uow) : base(uow) { }
    }
}
