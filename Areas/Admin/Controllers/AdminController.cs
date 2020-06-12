using Microsoft.AspNetCore.Mvc;

namespace projeto_livraria.Area.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}