using Book.Store.Domain.Entities;
using Book.Store.Domain.Interfaces.Repositories;
using Book.Store.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Book.Store.Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<BsLivro>, ILivroRepository
    {
        private IEnumerable<BsLivro> ListaLivrosAtivos()
        {
            return DbBookStoreContext.Livros.Where(e => e.Ativo);
        }

        public IEnumerable<BsLivro> ListarTodosOrdenadoPorNome()
        {
            return ListaLivrosAtivos().OrderBy(e => e.Nome);
        }

        public IEnumerable<BsLivro> ListarTodosOrdenadoPorAutor()
        {
            return ListaLivrosAtivos().OrderBy(e => e.Autor);
        }

        public IEnumerable<BsLivro> ObterLivrosPorNome(string nome)
        {
            return ListaLivrosAtivos().Where(livro => livro.Nome.Contains(nome));
        }

        public IEnumerable<BsLivro> ObterLivrosPorAutor(string autor)
        {
            return ListaLivrosAtivos().Where(livro => livro.Autor.Contains(autor));
        }

        public LivroRepository(BookStoreContext bookStoreDbContext)
            : base(bookStoreDbContext)
        {
        }
    }
}