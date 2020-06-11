using Microsoft.AspNetCore.Mvc;

namespace projeto_livraria.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
            return View();
            }
            return RedirectToAction ("Login", "Accout");
        }
    }
}