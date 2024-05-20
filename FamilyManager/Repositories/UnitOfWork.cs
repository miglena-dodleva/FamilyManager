using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace FamilyManager.Repositories
{
    public class UnitOfWork
    {
        private DbContext Context { get; set; }
        private IDbContextTransaction Transaction { get; set; }

        public UnitOfWork()
        {
            Context = new FamilyManagerDbContext();
            Transaction = null;
        }

        public object GetContext()
        {
            return Context;
        }

        public void BeginTransaction()
        {
            Transaction = Context.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (Transaction != null)
                Transaction.Commit();
        }

        public void Rollback()
        {
            if (Transaction != null)
                Transaction.Rollback();
        }
    }
}
