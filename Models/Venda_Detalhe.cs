using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projeto_livraria.Models
{
    public class Venda_Detalhe
    {   
        [Key]
        public int IdVenda_Detalhe { get; set; } 
        public int IdVenda {get; set; }
        public int IdLivro { get; set; }
        public int Quantidade {get; set; }
        public System.Decimal preco_uni { get; set; }
        public virtual Livro Livro { get; set; }
        public virtual Venda Venda { get; set; }
    }
}