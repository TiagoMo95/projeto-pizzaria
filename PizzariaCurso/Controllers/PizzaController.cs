﻿using Microsoft.AspNetCore.Mvc;

namespace PizzariaCurso.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
