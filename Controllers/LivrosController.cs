using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_livraria.Data;
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
            LivrosListViewModel.Livros = _context.Livro;
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
    }
}