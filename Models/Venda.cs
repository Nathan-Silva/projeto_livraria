using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_livraria.Models
{
    public class Venda
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdVenda { get; set; } 
        public List<Venda_Detalhe> Venda_Itens {get; set; }
        public DateTime Data_Venda { get; set; }
        public System.Decimal Venda_Total { get; set; }
        // public List<Livro> IdLivro { get; set; }
        [ForeignKey("Id_Cliente")]
        public Cliente IdCliente { get; set; }
    }
}