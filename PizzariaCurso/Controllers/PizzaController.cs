using Microsoft.AspNetCore.Mvc;

namespace PizzariaCurso.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
