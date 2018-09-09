using Book.Store.Domain.Entities;
using System.Collections.Generic;

namespace Book.Store.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceBase<BsLivro>
    {
        IEnumerable<BsLivro> ListarTodosOrdenadoPorNome();

        IEnumerable<BsLivro> ListarTodosOrdenadoPorAutor();

        IEnumerable<BsLivro> ObterLivrosPorNome(string nome);

        IEnumerable<BsLivro> ObterLivrosPorAutor(string autor);
    }
}