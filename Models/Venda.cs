using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projeto_livraria.Models
{
    public class Venda
    {   
        [Key]
        public int IdVenda { get; set; } 
        public List<VendaDetalhe> Venda_Itens {get; set; }
        public DateTime Data_Venda { get; set; }
        public System.Decimal Venda_Total { get; set; }
        public List<Livro> IdLivro { get; set; }
        public Cliente IdCliente { get; set; }
    }
}