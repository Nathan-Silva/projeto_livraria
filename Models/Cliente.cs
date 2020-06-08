using System.ComponentModel.DataAnnotations;

namespace projeto_livraria.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente {get; private set;}
        public string Nome { get; private set;}
        public long CPF { get; private set;}
        public Telefone IdTelefone { get; set;}
        public Endereco IdEnredeco { get; set;}
        
    }
}