using System.ComponentModel.DataAnnotations;

namespace projeto_livraria.Models
{
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set;}
        public string Rua { get; set;}
        public string Bairro { get; set;}
        public string Cidade { get; set;}
        public string Estado { get; set;}

    }
}