using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_livraria.Models
{
    public class Carrinho_Itens
    {
        [Key]
        public int IdCompra_Item {get; set; }
        [ForeignKey("IdLivro")]
        public Livro Livro {get; set; }
        public int Quantidade {get; set; }
        public string Carrinho_CompraId { get; set; }
    }
}