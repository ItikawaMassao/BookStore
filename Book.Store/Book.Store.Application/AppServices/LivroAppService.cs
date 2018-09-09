using AutoMapper;
using Book.Store.Application.Interfaces;
using Book.Store.Domain.DTO;
using Book.Store.Domain.Entities;
using Book.Store.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Book.Store.Application.AppServices
{
    public class LivroAppService : AppServiceBase<LivroDTO, BsLivro>, ILivroAppService
    {
        private readonly ILivroService _livroService;

        public LivroAppService(ILivroService livroService)
            : base(livroService)
        {
            _livroService = livroService;
        }

        public IEnumerable<LivroDTO> ListarTodosOrdenadoPorNome()
        {
            return Mapper.Map<IEnumerable<BsLivro>, IEnumerable<LivroDTO>>(_livroService.ListarTodosOrdenadoPorNome());
        }

        public IEnumerable<LivroDTO> ListarTodosOrdenadoPorAutor()
        {
            return Mapper.Map<IEnumerable<BsLivro>, IEnumerable<LivroDTO>>(_livroService.ListarTodosOrdenadoPorAutor());
        }

        public IEnumerable<LivroDTO> ObterLivrosPorNome(string nome)
        {
            return Mapper.Map<IEnumerable<BsLivro>, IEnumerable<LivroDTO>>(_livroService.ObterLivrosPorNome(nome));
        }

        public IEnumerable<LivroDTO> ObterLivrosPorAutor(string autor)
        {
            return Mapper.Map<IEnumerable<BsLivro>, IEnumerable<LivroDTO>>(_livroService.ObterLivrosPorAutor(autor));
        }
    }
}