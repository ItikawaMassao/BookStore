using Book.Store.Application.Interfaces;
using Book.Store.Domain.DTO;
using System.Collections.Generic;
using System.Web.Http;

namespace Book.Store.WebApi.Controllers
{
    public class LivrosController : ApiController
    {
        private readonly ILivroAppService _livroAppService;

        public LivrosController(ILivroAppService livroAppService)
        {
            _livroAppService = livroAppService;
        }

        [HttpGet]
        public IEnumerable<LivroDTO> Get()
        {
            return _livroAppService.ListarTodosOrdenadoPorNome();
        }

        [HttpGet]
        public LivroDTO Get(int id)
        {
            return _livroAppService.ObterPorId(id);
        }

        [HttpPut]
        public void Put([FromBody]LivroDTO dtoLivro)
        {
            _livroAppService.Adicionar(dtoLivro);
        }

        [HttpPost]
        public void Post(int id, [FromBody]LivroDTO dtoLivro)
        {
            _livroAppService.Alterar(id, dtoLivro);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _livroAppService.Remover(id);
        }
    }
}