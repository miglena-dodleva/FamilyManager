using FamilyManager.Entities;

namespace FamilyManager.Repositories
{
    public class FamiliesRepository : BaseRepository<Family>
    {
        public FamiliesRepository() : base() { }
        public FamiliesRepository(UnitOfWork uow) : base(uow) { }
    }
}
