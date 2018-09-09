using Book.Store.Domain.DTO;
using Book.Store.MVC.Business.Consumer;
using System.Collections.Generic;
using System.Web.Configuration;

namespace Book.Store.MVC.Areas.Livros.Business
{
    public class LivrosBusiness
    {
        private readonly ApiConsumerClient _apiConsumerClient;

        public LivrosBusiness()
        {
            _apiConsumerClient = new ApiConsumerClient(WebConfigurationManager.AppSettings["endpointApiService"]);
        }

        public IEnumerable<LivroDTO> ListarTodos()
        {
            return _apiConsumerClient.GetAsync<IEnumerable<LivroDTO>>("api/livros/Get");
        }

        public LivroDTO ObterLivroPorId(long idLivro)
        {
            return _apiConsumerClient.GetAsync<LivroDTO>(string.Format("api/livros/Get/{0}", idLivro));
        }

        public void Adicionar(LivroDTO dtoLivro)
        {
            _apiConsumerClient.PutAsync("api/livros/Put", dtoLivro);
        }

        public void Alterar(long idLivro, LivroDTO dtoLivro)
        {
            _apiConsumerClient.PostAsync(string.Format("api/livros/Post/{0}", idLivro), dtoLivro);
        }

        public void Remover(long idLivro)
        {
            _apiConsumerClient.DeleteAsync(string.Format("api/livros/Delete/{0}", idLivro));
        }
    }
}