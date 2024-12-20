﻿using Microsoft.AspNetCore.Mvc;
using PizzariaCurso.Dto;
using PizzariaCurso.Services.Pizza;

namespace PizzariaCurso.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaInterface _pizzaInterface;

        public PizzaController(IPizzaInterface pizzaInterface)
        {
            _pizzaInterface = pizzaInterface;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(PizzaCriacaoDto pizzaCriacaoDto, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                var pizza = await _pizzaInterface.CriarPizza(pizzaCriacaoDto, foto);
                return RedirectToAction("Index", "Pizza");
            }
            else
            {
                return View(pizzaCriacaoDto);
            }
        }
    }
}
