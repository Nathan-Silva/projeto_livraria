using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using projeto_livraria.Data;
using projeto_livraria.Models;
using projeto_livraria.ViewModel;

namespace AppWeb.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly LivrariaContext _LivrariaContext;
        private CarrinhoCompra _CarrinhoCompra;

        public CarrinhoCompraController(LivrariaContext LivrariaContext,
                                        CarrinhoCompra CarrinhoCompra)
        {
            _LivrariaContext = LivrariaContext;
            _CarrinhoCompra = CarrinhoCompra;

        }

        public IActionResult Index()
        {
            var itens = _CarrinhoCompra.GetCarrinho_Item();
            _CarrinhoCompra.Carrinho_Item = itens;

            var CarrinhoCompraViewModel = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _CarrinhoCompra,
                CarrinhoCompraTotal = _CarrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(CarrinhoCompraViewModel);
        }

        [Authorize]
        [Route("CarrinhoCompra/Index")]
        public RedirectToActionResult AdicionarItemNoCarrinhoCompra(int IdLivro)
        {
            var livroSelecionado = _LivrariaContext.Livro.FirstOrDefault(p => p.IdLivro == IdLivro);

            if (livroSelecionado != null)
            {
                _CarrinhoCompra.AdicionarAoCarrinho(livroSelecionado, 1);
            }
            return RedirectToAction("Index");
        }

        [Authorize]
        public RedirectToActionResult RemoverItemNoCarrinhoCompra(int IdLivro)
        {
            var livroSelecionado = _LivrariaContext.Livro.FirstOrDefault(p => p.IdLivro == IdLivro);

            if (livroSelecionado != null)
            {
                _CarrinhoCompra.RemoverDoCarrinho(livroSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}