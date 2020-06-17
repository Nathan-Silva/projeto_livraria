using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using projeto_livraria.Data;
using projeto_livraria.Models;
using projeto_livraria.ViewModel;

namespace projeto_livraria.Controllers
{
    public class LivrosController : Controller 
    {
        // private readonly ILogger<LivrosController> _logger;
        private readonly LivrariaContext _context;
        public LivrosController(LivrariaContext context)
        {
             _context = context;
        }
        [Route("Livros/List")]
        public IActionResult List()
        {
            ViewBag.livros = "livro";
        
            var LivrosListViewModel = new LivroListViewModel(); 
            LivrosListViewModel.Livro = _context.Livro;
            return View(LivrosListViewModel);
        }
        [Route("Home/Details")]
        public IActionResult Details(int IdLivro)
        {
            var livro = _context.Livro.FirstOrDefault(I=> I.IdLivro == IdLivro);
            if(livro == null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            return View(livro);
        }
        public IActionResult Busca(string buscaString)
        {
            string _buscaString = buscaString;
            IEnumerable<Livro> livro;

            if (string.IsNullOrEmpty(_buscaString))
            {
                livro = _context.Livro.OrderBy(l => l.IdLivro);
            }
            else
            {
                livro = _context.Livro.Where(l => l.Titulo.ToLower().Contains(_buscaString.ToLower()));
            }
            return View("~/Views/Livros/List.cshtml", new LivroListViewModel {Livro = livro});
        }
    }
}