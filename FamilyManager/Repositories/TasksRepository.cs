using FamilyManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyManager.Repositories
{
    public class TasksRepository : BaseRepository<Entities.Task>
    {
        public TasksRepository() : base() { }
        public TasksRepository(UnitOfWork uow) : base(uow) { }
    }
}
