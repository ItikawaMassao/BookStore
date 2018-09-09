using Book.Store.Domain.Entities;
using Book.Store.Domain.Interfaces.Repositories;
using Book.Store.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Book.Store.Domain.Services
{
    public class LivroService : ServiceBase<BsLivro>, ILivroService
    {
        public LivroService(ILivroRepository repositoryBase)
            : base(repositoryBase)
        {
        }

        public IEnumerable<BsLivro> ListarTodosOrdenadoPorNome()
        {
            var livroRepository = RepositoryBase as ILivroRepository;
            return livroRepository != null ? livroRepository.ListarTodosOrdenadoPorNome() : Enumerable.Empty<BsLivro>();
        }

        public IEnumerable<BsLivro> ListarTodosOrdenadoPorAutor()
        {
            var livroRepository = RepositoryBase as ILivroRepository;
            return livroRepository != null ? livroRepository.ListarTodosOrdenadoPorAutor() : Enumerable.Empty<BsLivro>();
        }

        public IEnumerable<BsLivro> ObterLivrosPorNome(string nome)
        {
            var livroRepository = RepositoryBase as ILivroRepository;
            return livroRepository != null ? livroRepository.ObterLivrosPorNome(nome) : Enumerable.Empty<BsLivro>();
        }

        public IEnumerable<BsLivro> ObterLivrosPorAutor(string autor)
        {
            var livroRepository = RepositoryBase as ILivroRepository;
            return livroRepository != null ? livroRepository.ObterLivrosPorAutor(autor) : Enumerable.Empty<BsLivro>();
        }
    }
}