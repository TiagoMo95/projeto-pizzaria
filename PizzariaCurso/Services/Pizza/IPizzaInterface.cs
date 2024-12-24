using PizzariaCurso.Dto;
using PizzariaCurso.Models;
using PizzariaCurso.Data;

namespace PizzariaCurso.Services.Pizza
{
    public interface IPizzaInterface
    {
        Task<PizzaModel> CriarPizza(PizzaCriacaoDto pizzaCriacaoDto, IFormFile foto);
        Task<List<PizzaModel>> GetPizzas();
        Task<PizzaModel> GetPizzaPorId(int id);
        Task<PizzaModel> EditarPizza(PizzaModel pizza, IFormFile? foto);
        Task<PizzaModel?> RemoverPizza(int id);
    }
}
