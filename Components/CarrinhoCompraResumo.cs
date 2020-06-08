using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projeto_livraria.Models;
using projeto_livraria.ViewModel;

namespace projeto_livraria.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly CarrinhoCompra _CarrinhoCompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
        {
            _CarrinhoCompra = carrinhoCompra;
        }
        public IViewComponentResult Invoke()
        {
            var itens = _CarrinhoCompra.GetCarrinho_Item();
            _CarrinhoCompra.Carrinho_Item = itens;

            var CarrinhoCompraVM = new CarrinhoCompraViewModel
            {
              CarrinhoCompra = _CarrinhoCompra,
              CarrinhoCompraTotal = _CarrinhoCompra.GetCarrinhoCompraTotal()  
            };
            return View (CarrinhoCompraVM);
        }
        
    }
}