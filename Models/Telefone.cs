using System.ComponentModel.DataAnnotations;

namespace projeto_livraria.Models
{
    public class Telefone
    {
        [Key]
        public int IdTelefone {get; set;}
        public string Tipo { get; set;}
        public long Numero { get; set;}
    }
}