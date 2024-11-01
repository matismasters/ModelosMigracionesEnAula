using Microsoft.EntityFrameworkCore;
using ModelosMigracionesEnAula.Models;  

namespace ModelosMigracionesEnAula.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define el DbSet para tu modelo
        public DbSet<Producto> Productos { get; set; }
    }
}
