using Book.Store.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;

namespace Book.Store.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class, IEntityBase, new()
    {
        void Add(TEntity entidade);

        void Update(TEntity entidade);

        void Remove(TEntity entidade);

        TEntity GetById(long id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAllSorted<TSource, TKey>(Func<TSource, TKey> orderByMethod);
    }
}