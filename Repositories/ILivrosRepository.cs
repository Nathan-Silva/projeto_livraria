using System.Collections.Generic;
using projeto_livraria.Models;

namespace Repositories
{
    public interface ILivrosRepository 
    {
        IEnumerable<Livro> Livro{ get; }
        Livro GetLivroById(int IdLivro);
    }
}
