using Book.Store.Application.Interfaces;
using Book.Store.Domain.DTO;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Book.Store.WebApi.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar o CRUD de livros
    /// </summary>
    [RoutePrefix("api/Livros")]
    public class LivrosController : ApiController
    {
        private readonly ILivroAppService _livroAppService;

        public LivrosController(ILivroAppService livroAppService)
        {
            _livroAppService = livroAppService;
        }

        /// <summary>
        /// Consulta a lista de livros disponíveis
        /// </summary>
        /// <returns>
        /// Lista de livros, contendo Nome, Autor e Editora
        /// </returns>
        [HttpGet]
        [Route("Get")]
        [ResponseType(typeof(IEnumerable<LivroDTO>))]
        public IEnumerable<LivroDTO> Get()
        {
            return _livroAppService.ListarTodosOrdenadoPorNome();
        }

        /// <summary>
        /// Consulta um determinado livro, conforme seu identificador
        /// </summary>
        /// <param name="id">Identificador do livro</param>
        /// <returns>
        /// Retorna o livro consultado, conforme o identificador informado
        /// </returns>
        [HttpGet]
        [Route("Get/{id}")]
        [ResponseType(typeof(LivroDTO))]
        public LivroDTO Get(int id)
        {
            return _livroAppService.ObterPorId(id);
        }

        /// <summary>
        /// Insere um novo livro
        /// </summary>
        /// <param name="dtoLivro">Dados do livro (Nome, Autor e Editora) </param>
        /// <returns>
        /// Retorna a resposta com o StatusCode
        /// </returns>
        [HttpPut]
        [Route("Put")]
        [ResponseType(typeof(IHttpActionResult))]
        public IHttpActionResult Put([FromBody]LivroDTO dtoLivro)
        {
            _livroAppService.Adicionar(dtoLivro);
            return Ok();
        }

        /// <summary>
        /// Realiza a alteração de um livro
        /// </summary>
        /// <param name="id">Identificador do livro para alteração</param>
        /// <param name="dtoLivro">Dados do livro</param>
        /// <returns>
        /// Retorna a resposta com o StatusCode
        /// </returns>
        [HttpPost]
        [Route("Post/{id}")]
        [ResponseType(typeof(IHttpActionResult))]
        public IHttpActionResult Post(int id, [FromBody]LivroDTO dtoLivro)
        {
            _livroAppService.Alterar(id, dtoLivro);
            return Ok();
        }

        /// <summary>
        /// Realiza a exclusão de um livro
        /// </summary>
        /// <param name="id">Identificador do livro para exclusão</param>
        /// <returns>
        /// Retorna a resposta com o StatusCode
        /// </returns>
        [HttpDelete]
        [Route("Delete/{id}")]
        [ResponseType(typeof(IHttpActionResult))]
        public IHttpActionResult Delete(int id)
        {
            _livroAppService.Remover(id);
            return Ok();
        }
    }
}