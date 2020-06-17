
using System.ComponentModel.DataAnnotations;

namespace projeto_livraria.Models
{
    public class Livro
    {
        [Key]
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Descricao {get; set; }
        public int Ano {get; set; }
        public int Numero_de_Paginas {get; set; }
        public string Acabamento {get; set; }
        public string Idioma {get; set; }
        public string Pais {get; set; }
        public System.Decimal Altura {get; set; }
        public System.Decimal Largura {get; set; }
        public System.Decimal Peso {get; set; }
        public System.Decimal Preco { get; set; }
        public string Imagem {get; set; }
    }
}