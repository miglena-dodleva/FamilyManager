﻿using FamilyManager.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FamilyManager.Repositories
{
    public abstract class BaseRepository<T>
        where T :BaseEntity
    {
        private DbContext Context { get; set; }
        private DbSet<T> Items { get; set; }

        public BaseRepository()
        {
            Context = new FamilyManagerDbContext();
            Items = Context.Set<T>();
        }

        public BaseRepository(UnitOfWork uow)
        {
            Context = (DbContext)uow.GetContext();
            Items = Context.Set<T>();
        }

        public List<T> GetAll<O>(
        Expression<Func<T, bool>> filter = null,
        Expression<Func<T, O>> order = null,
        int page = 1,
        int itemsPerPage = int.MaxValue
        )
        {
            IQueryable<T> query = Items;

            if (filter != null)
                query = query.Where(filter);

            if (order == null)
                query = query.OrderBy(i => i.Id);
            else
                query = query.OrderBy(order);

            return query
                      .Skip((page - 1) * itemsPerPage)
                      .Take(itemsPerPage)
                      .ToList();
        }

        public T GetById(int id)
        {
            return Items.Where(item => item.Id == id).FirstOrDefault();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> filter)
        {
            return Items
                      .Where(filter)
                      .FirstOrDefault();
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = Items;

            if (filter != null)
                query = query.Where(filter);

            return query.Count();
        }

        public void Save(T item)
        {
            if (item.Id > 0)
                Items.Update(item);
            else
                Items.Add(item);

            Context.SaveChanges();
        }

        public void Delete(T item)
        {
            Items.Remove(item);
            Context.SaveChanges();
        }

        public void Add(T item)
        {
            Context.Set<T>().Add(item);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
