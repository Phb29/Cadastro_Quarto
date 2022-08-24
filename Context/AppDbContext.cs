using Quartos.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroQuarto.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Quarto> Quartos { get; set; }
    }
}
