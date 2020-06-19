using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using projeto_livraria.Models;
using projeto_livraria.Repositories;

namespace projeto_livraria.Controllers
{
    public class VendaController : Controller
    {                
            private readonly IVendaRepository _vendaRepository;
            private readonly CarrinhoCompra _carrinhoCompra;

            public VendaController(IVendaRepository vendaRepository, CarrinhoCompra carrinhoCompra)
            {
                _vendaRepository = vendaRepository;
                _carrinhoCompra = carrinhoCompra;
            }

            [Route("Venda/Formulario")]
            [HttpGet]
            [Authorize]
            public IActionResult Formulario()
            {
                return View();
            }

            [HttpPost]
            [Authorize]
            public IActionResult Formulario(Venda venda)
            {
            
            var Itens = _carrinhoCompra.GetCarrinho_Item();
            _carrinhoCompra.Carrinho_Item = Itens;

            if(_carrinhoCompra.Carrinho_Item.Count == 0)
            {
                ModelState.AddModelError("","Seu Carrinho esta vazio");
                return View(venda);

            }
            
            if(ModelState.IsValid)
            {
                _vendaRepository.CriarVenda(venda);
                _carrinhoCompra.LimparCarrinho();
                return RedirectToAction("FormularioCompleto");
            }
            return View(venda);
            }

            [Route("Venda/FormularioCompleto")]
            public IActionResult FormularioCompleto()
            {
                ViewBag.FormularioCompletoMensagem = "Obrigado pela sua compra!";
                return View();
            }
    }
}