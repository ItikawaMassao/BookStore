using Book.Store.Domain.Entities;
using Book.Store.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Book.Store.Infra.Data.Context;

namespace Book.Store.Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<BsLivro>, ILivroRepository
    {
        public IEnumerable<BsLivro> ListarTodosOrdenadoPorNome()
        {
            return GetAllSorted(new Func<BsLivro, string>(e => e.Nome));
        }

        public IEnumerable<BsLivro> ListarTodosOrdenadoPorAutor()
        {
            return GetAllSorted(new Func<BsLivro, string>(e => e.Autor));
        }

        public IEnumerable<BsLivro> ObterLivrosPorNome(string nome)
        {
            return DbBookStoreContext.Livros.Where(livro => livro.Nome.Contains(nome));
        }

        public IEnumerable<BsLivro> ObterLivrosPorAutor(string autor)
        {
            return DbBookStoreContext.Livros.Where(livro => livro.Autor.Contains(autor));
        }

        public LivroRepository(BookStoreContext bookStoreDbContext)
            : base(bookStoreDbContext)
        {
        }
    }
}