using System.Collections.Generic;
using Book.Store.Domain.Entities;

namespace Book.Store.Domain.Interfaces.Repositories
{
    public interface ILivroRepository : IRepositoryBase<BsLivro>
    {
        IEnumerable<BsLivro> ListarTodosOrdenadoPorNome();

        IEnumerable<BsLivro> ListarTodosOrdenadoPorAutor();

        IEnumerable<BsLivro> ObterLivrosPorNome(string nome);

        IEnumerable<BsLivro> ObterLivrosPorAutor(string autor);
    }
}