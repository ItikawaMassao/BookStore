using Book.Store.Domain.Interfaces.Entities;

namespace Book.Store.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class, IEntityBase, new()
    {
        void Adicionar(TEntity entity);

        void Alterar(TEntity entity);

        void Remover(long id);

        TEntity ObterPorId(long id);
    }
}