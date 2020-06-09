using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppWeb.Models;
using projeto_livraria.Data;
using projeto_livraria.ViewModel;

namespace AppWeb.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        private readonly LivrariaContext _context;

      

        public HomeController(LivrariaContext context)
        {
            _context = context;      
        }
        public IActionResult Index()
        {
            ViewBag.livros = "livro";
         
        //    var livros  = _context.Livro;
        //     return View(livros);
        
            var LivrosListViewModel = new LivroListViewModel(); 
            LivrosListViewModel.Livro = _context.Livro;
            return View(LivrosListViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
