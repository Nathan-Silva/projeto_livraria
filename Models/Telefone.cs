using System.ComponentModel.DataAnnotations;

namespace projeto_livraria.Models
{
    public class Telefone
    {
        [Key]
        public int IdTelefone {get; private set;}
        public string Tipo { get; private set;}
        public long Numero { get; private set;}
    }
}