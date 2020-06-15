using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using projeto_livraria.Data;
using projeto_livraria.Models;
using System.Linq;
using System.Threading.Tasks;
using ReflectionIT.Mvc.Paging;
// using projeto_livraria.Context;

namespace projeto_livraria.Area.Admin.Controllers
{
    [Route("Admin/AdminLivros/Index")]
    [Area("Admin")]
    // [Authorize(Roles = "Admin")]
    public class AdminLivrosController : Controller
    {
        private readonly LivrariaContext _context;

        public AdminLivrosController(LivrariaContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminLivros
        // public async Task<IActionResult> Index()
        // {
        //     var appDbContext = _context.Livro;
        //     return View(await appDbContext.ToListAsync());
        // }

        public async Task<IActionResult> Index(string filter, int pageindex = 1, string sort = "Titulo")
        {
            var resultado = _context.Livro.AsQueryable();
            
            if (!string.IsNullOrWhiteSpace(filter))
            {
                resultado = resultado.Where(l => l.Titulo.Contains(filter));
            }

            var model = await PagingList.CreateAsync(resultado, 5, pageindex, sort, "Nome");

            model.RouteValue = new RouteValueDictionary { { "filter", filter } };

            return View(model);
        }

        // GET: Admin/AdminLivros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro
                .FirstOrDefaultAsync(m => m.IdLivro == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        //POST: Admin/AdminLivros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLivro,Titulo,Autor,Editora,Descricao,Ano,Numero_de_Paginas,Acabamento,Idioma,Pais,Altura,Largura,Peso,Preco")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }

        // GET: Admin/AdminLivros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro);
        }

        // POST: Admin/AdminLivros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLivro,Titulo,Autor,Editora,Descricao,Ano,Numero_de_Paginas,Acabamento,Idioma,Pais,Altura,Largura,Peso,Preco")] Livro livro)
        {
            if (id != livro.IdLivro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.IdLivro))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }

        // GET: Admin/AdminLivros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro
                .FirstOrDefaultAsync(m => m.IdLivro == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // POST: Admin/AdminLivros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livro = await _context.Livro.FindAsync(id);
            _context.Livro.Remove(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(int id)
        {
            return _context.Livro.Any(e => e.IdLivro == id);
        }
    }
}
