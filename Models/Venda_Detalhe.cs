using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_livraria.Models
{
    public class Venda_Detalhe
    {   
        [Key]
        public int IdVenda_Detalhe { get; set; }
        public int Quantidade {get; set; }
        public System.Decimal Preco_uni { get; set; }
        [ForeignKey("Id_Livro")]
        public virtual Livro IdLivro { get; set; }
        [ForeignKey("Id_Venda")]
        public virtual Venda IdVenda { get; set; }
    }
}