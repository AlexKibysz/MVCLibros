using Microsoft.EntityFrameworkCore;
using MVCLibros.Models;

namespace MVCLibros.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Peliculas> Peliculas { get; set; }
    }
}
