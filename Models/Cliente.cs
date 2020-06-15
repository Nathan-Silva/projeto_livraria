using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_livraria.Models
{
    public class Cliente
    {

        [Key]
        public int IdCliente {get; private set;}
        public string Nome { get; set;}
        public string CPF { get; set;}
        
        [ForeignKey("Id_Telefone")]
        public Telefone Telefone { get; set;}
        [ForeignKey("Id_Endereco")]
        public Endereco Endereco { get; set;}
        public Venda Venda { get; set; }
        
    }
}