using PizzariaCurso.Dto;
using PizzariaCurso.Models;
using PizzariaCurso.Data;

namespace PizzariaCurso.Services.Pizza
{
    public interface IPizzaInterface
    {
        Task<PizzaModel> CriarPizza(PizzaCriacaoDto pizzaCriacaoDto, IFormFile foto);
    }
}
