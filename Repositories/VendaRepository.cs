using System;
using projeto_livraria.Data;
using projeto_livraria.Models;

namespace projeto_livraria.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly LivrariaContext _livrariaContext;

        public CarrinhoCompra _CarrinhoCompra { get; }

        public VendaRepository(LivrariaContext livrariaContext,
                               CarrinhoCompra carrinhoCompra)
        {
            _livrariaContext = livrariaContext;
            _CarrinhoCompra = carrinhoCompra;
        }
        public void CriarVenda(Venda venda)
        {
            venda.Data_Venda = DateTime.Now;
            _livrariaContext.Venda.Add(venda);

            var CarrinhoCompraItens = _CarrinhoCompra.Carrinho_Item;

            foreach(var Carrinho_Item in CarrinhoCompraItens)
            {
                var VendaDetalhe = new Venda_Detalhe()
                {
                    Quantidade = Carrinho_Item.Quantidade,
                    IdLivro = Carrinho_Item.Livro.IdLivro,
                    IdVenda = venda.IdVenda,
                    preco_uni = Carrinho_Item.Livro.Preco,
                };

                _livrariaContext.Venda_Detalhe.Add(VendaDetalhe);
            }
            _livrariaContext.SaveChanges();
        }
    }
}