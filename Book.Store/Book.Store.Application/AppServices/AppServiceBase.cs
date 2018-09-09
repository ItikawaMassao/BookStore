using AutoMapper;
using Book.Store.Application.Interfaces;
using Book.Store.Domain.DTO;
using Book.Store.Domain.Interfaces.Entities;
using Book.Store.Domain.Interfaces.Services;

namespace Book.Store.Application.AppServices
{
    public class AppServiceBase<TDto, TEntity> : IAppServiceBase<TDto>
        where TDto : BaseDTO
        where TEntity : class, IEntityBase, new()
    {
        protected readonly IServiceBase<TEntity> EntityServiceBase;

        public AppServiceBase(IServiceBase<TEntity> entityService)
        {
            EntityServiceBase = entityService;
        }

        public void Adicionar(TDto dto)
        {
            EntityServiceBase.Adicionar(Mapper.Map<TDto, TEntity>(dto));
        }

        public void Alterar(long id, TDto dto)
        {
            dto.Id = id;
            EntityServiceBase.Alterar(Mapper.Map<TDto, TEntity>(dto));
        }

        public void Remover(long id)
        {
            EntityServiceBase.Remover(id);
        }

        public TDto ObterPorId(long id)
        {
            return Mapper.Map<TEntity, TDto>(EntityServiceBase.ObterPorId(id));
        }
    }
}