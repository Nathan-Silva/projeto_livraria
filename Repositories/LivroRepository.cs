using System.Collections.Generic;
using System.Linq;
using projeto_livraria.Data;
using projeto_livraria.Models;
using Repositories;

namespace projeto_livraria.Repositories
{
    public class LivroRepository : ILivrosRepository
    {
        private readonly LivrariaContext _context;

        public LivroRepository(LivrariaContext context)
        {
            _context = context;
        }
        public IEnumerable<Livro> Livro => _context.Livro;

        public Livro GetLivroById(int IdLivro)
        {
            return _context.Livro.FirstOrDefault(l => l.IdLivro == IdLivro);
        }
        
    }
}