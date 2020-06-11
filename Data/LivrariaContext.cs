using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using projeto_livraria.Models;

namespace projeto_livraria.Data
{
    public class LivrariaContext : IdentityDbContext<IdentityUser>
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options) : base(options)
        {

        }
        public DbSet<Livro> Livro {get; set;}
        public DbSet<Carrinho_Itens> Carrinho_Itens {get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Venda_Detalhe> Venda_Detalhe { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
    }
}