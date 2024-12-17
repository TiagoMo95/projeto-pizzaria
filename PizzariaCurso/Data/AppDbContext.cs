using Microsoft.EntityFrameworkCore;
using PizzariaCurso.Models;

namespace PizzariaCurso.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<PizzaModel> Pizzas { get; set; }
    }
}
