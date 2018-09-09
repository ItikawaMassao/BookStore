using AutoMapper;
using Book.Store.Domain.DTO;
using Book.Store.MVC.ViewModels.Livros;
using System.Collections.Generic;
using System.Web.Mvc;
using Book.Store.MVC.Areas.Livros.Business;

namespace Book.Store.MVC.Areas.Livros.Controllers
{
    public class LivrosController : Controller
    {
        private readonly LivrosBusiness _livrosBusiness;

        public LivrosController()
        {
            _livrosBusiness = new LivrosBusiness();
        }

        public ActionResult Index()
        {
            var listaLivrosViewModel = Mapper.Map<IEnumerable<LivroDTO>, IEnumerable<LivroViewModel>>(_livrosBusiness.ListarTodos());
            return View(listaLivrosViewModel);
        }

        public ActionResult Details(int id)
        {
            var livroViewModel = Mapper.Map<LivroDTO, LivroViewModel>(_livrosBusiness.ObterLivroPorId(id));
            return View(livroViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(LivroViewModel livroViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var livro = Mapper.Map<LivroViewModel, LivroDTO>(livroViewModel);
                    _livrosBusiness.Adicionar(livro);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var livro = _livrosBusiness.ObterLivroPorId(id);
            var livroViewModel = Mapper.Map<LivroDTO, LivroViewModel>(livro);

            return View(livroViewModel);
        }

        [HttpPost]
        public ActionResult Edit(int id, LivroViewModel livroViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var livro = Mapper.Map<LivroViewModel, LivroDTO>(livroViewModel);
                    _livrosBusiness.Alterar(id, livro);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var livro = _livrosBusiness.ObterLivroPorId(id);
            var livroViewModel = Mapper.Map<LivroDTO, LivroViewModel>(livro);

            return View(livroViewModel);
        }

        [HttpPost]
        public ActionResult Delete(int id, LivroViewModel livroViewModel)
        {
            try
            {
                _livrosBusiness.Remover(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}