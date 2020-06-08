using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using projeto_livraria.Data;

namespace projeto_livraria.Models
{
    public class CarrinhoCompra
    {
        private readonly LivrariaContext _context;

        public CarrinhoCompra(LivrariaContext context)
        {
            _context = context;
        }
        public string Carrinho_CompraId { get; set; }
        public List<Carrinho_Itens> Carrinho_Item { get; set; }

        public static CarrinhoCompra GetCarrinho(System.IServiceProvider services)
        {
            // Define uma sessão acessando o contexto atual (tem que registrar em IServiceContext)
            ISession session =
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            // Obtem um serviço do tipo do nosso contexto
            var context = services.GetService<LivrariaContext>();

            // Obtem ou gera o Id Carrinho
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            // Atribui o Id do carrinho na sessão
            session.SetString("CarrinhoId", carrinhoId);

            //retorna o carrinho com contexto atual e o Id atribuido ou obtido
            return new CarrinhoCompra(context)
            {
                Carrinho_CompraId = carrinhoId
            };
        }
        public void AdicionarAoCarrinho(Livro livro, int quantidade)
        {
            var Carrinho_Item =
            _context.Carrinho_Itens.SingleOrDefault(
                s => s.Livro.IdLivro == livro.IdLivro && s.Carrinho_CompraId == Carrinho_CompraId);

            // Verifica se o carrinho existe e senão existir cria um
            if (Carrinho_Item == null)
            {
                Carrinho_Item = new Carrinho_Itens
                {
                    Carrinho_CompraId = Carrinho_CompraId,
                    Livro = livro,
                    Quantidade = 1
                };
                _context.Carrinho_Itens.Add(Carrinho_Item);
            }
            else // Se existir o carrinho com item então incrementa a quantidade
            {
                Carrinho_Item.Quantidade++;
            }
            _context.SaveChanges();
        }
        public int RemoverDoCarrinho(Livro livro)
        {
            var Carrinho_Item =
                _context.Carrinho_Itens.SingleOrDefault(
                    s => s.Livro.IdLivro == livro.IdLivro && s.Carrinho_CompraId == Carrinho_CompraId);

            var quantidadeLocal = 0;

            if (Carrinho_Item != null)
            {
                if (Carrinho_Item.Quantidade > 1)
                {
                    Carrinho_Item.Quantidade--;
                    quantidadeLocal = Carrinho_Item.Quantidade;
                }
                else
                {
                    _context.Carrinho_Itens.Remove(Carrinho_Item);
                }
            }
            _context.SaveChanges();

            return quantidadeLocal;
        }
        public List<Carrinho_Itens> GetCarrinho_Item()
        {
            return Carrinho_Item ??
            (_context.Carrinho_Itens.Where(c => c.Carrinho_CompraId == Carrinho_CompraId)
                           .Include(s => s.Livro)
                           .ToList());
                  
        }
        public void LimparCarrinho()
        {
            var CarrinhoItens =_context.Carrinho_Itens
            .Where(Carrinho => Carrinho.Carrinho_CompraId == Carrinho_CompraId);

            _context.Carrinho_Itens.RemoveRange(CarrinhoItens);
            _context.SaveChanges();
        }
        public decimal GetCarrinhoCompraTotal()
        {
            var total = _context.Carrinho_Itens.Where(c => c.Carrinho_CompraId == Carrinho_CompraId)
                .Select (c => c.Livro.Preco * c.Quantidade).Sum();

            return total;
        }
    }
}