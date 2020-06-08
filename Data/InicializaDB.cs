using projeto_livraria.Models;

namespace projeto_livraria.Data
{
    public class InicializaDB
    {
        public static void Initialize(LivrariaContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}