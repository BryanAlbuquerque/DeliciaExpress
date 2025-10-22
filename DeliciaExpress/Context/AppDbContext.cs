using DeliciaExpress.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliciaExpress.Context

{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
    }
}
