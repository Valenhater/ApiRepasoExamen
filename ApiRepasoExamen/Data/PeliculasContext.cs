using ApiRepasoExamen.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRepasoExamen.Data
{
    public class PeliculasContext:DbContext
    {
        public PeliculasContext(DbContextOptions<PeliculasContext> options) : base(options) { }

        public DbSet<Pelicula> Peliculas { get; set; } 
        public DbSet<Genero> Generos { get; set; }
    }
}
