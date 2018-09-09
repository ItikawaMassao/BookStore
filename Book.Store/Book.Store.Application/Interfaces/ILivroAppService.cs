using System.Collections.Generic;
using Book.Store.Domain.DTO;

namespace Book.Store.Application.Interfaces
{
    public interface ILivroAppService : IAppServiceBase<LivroDTO>
    {
        IEnumerable<LivroDTO> ListarTodosOrdenadoPorNome();

        IEnumerable<LivroDTO> ListarTodosOrdenadoPorAutor();

        IEnumerable<LivroDTO> ObterLivrosPorNome(string nome);

        IEnumerable<LivroDTO> ObterLivrosPorAutor(string autor);
    }
}