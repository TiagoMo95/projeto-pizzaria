using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace PizzariaCurso.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
