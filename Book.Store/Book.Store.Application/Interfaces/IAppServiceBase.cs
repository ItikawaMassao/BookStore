using Book.Store.Domain.DTO;

namespace Book.Store.Application.Interfaces
{
    public interface IAppServiceBase<TDataTransferObject> where TDataTransferObject : BaseDTO
    {
        void Adicionar(TDataTransferObject dto);

        void Alterar(long id, TDataTransferObject dto);

        void Remover(long id);

        TDataTransferObject ObterPorId(long id);
    }
}