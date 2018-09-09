using Book.Store.Domain.Interfaces;
using Book.Store.Domain.Interfaces.Entities;
using Book.Store.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Book.Store.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity>
        where TEntity : class , IEntityBase, new()
    {
        protected BookStoreContext DbBookStoreContext;

        public RepositoryBase(BookStoreContext bookStoreDbContext)
        {
            DbBookStoreContext = bookStoreDbContext;
        }

        public void Dispose()
        {
            DbBookStoreContext.Dispose();
        }

        public void Add(TEntity entidade)
        {
            DbBookStoreContext.Set<TEntity>().Add(entidade);
            DbBookStoreContext.SaveChanges();
        }

        public void Update(TEntity entidade)
        {
            DbBookStoreContext.Entry(entidade).State = EntityState.Modified;
            DbBookStoreContext.SaveChanges();
        }

        public void Remove(TEntity entidade)
        {
            entidade.Ativo = false;
            Update(entidade);
        }

        public TEntity GetById(long id)
        {
            return DbBookStoreContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbBookStoreContext.Set<TEntity>().Where(e => e.Ativo).ToList();
        }

        public IEnumerable<TEntity> GetAllSorted<TSource, TKey>(Func<TSource, TKey> orderByMethod)
        {
            return DbBookStoreContext.Set<TEntity>().Where(e => e.Ativo).ToList().OrderBy(e => orderByMethod);
        }
    }
}