using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class UserToCalendarsRepostory : BaseRepository<UserToCalendar>
    {
        public UserToCalendarsRepostory() : base() { }
        public UserToCalendarsRepostory(UnitOfWork uow) : base(uow) { }
    }
}
