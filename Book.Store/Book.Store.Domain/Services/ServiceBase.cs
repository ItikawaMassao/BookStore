using Book.Store.Domain.Interfaces;
using Book.Store.Domain.Interfaces.Entities;
using Book.Store.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Book.Store.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class, IEntityBase, new()
    {
        protected readonly IRepositoryBase<TEntity> RepositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            RepositoryBase = repositoryBase;
        }

        public void Adicionar(TEntity entity)
        {
            RepositoryBase.Add(entity);
        }

        public void Alterar(TEntity entity)
        {
            RepositoryBase.Update(entity);
        }

        public void Remover(long id)
        {
            RepositoryBase.Remove(RepositoryBase.GetById(id));
        }

        public TEntity ObterPorId(long id)
        {
            return RepositoryBase.GetById(id);
        }

        public IEnumerable<TEntity> ListarTodos()
        {
            return RepositoryBase.GetAll();
        }
    }
}