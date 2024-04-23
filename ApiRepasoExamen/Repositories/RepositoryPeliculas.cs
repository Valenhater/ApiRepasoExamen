using ApiRepasoExamen.Data;
using ApiRepasoExamen.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRepasoExamen.Repositories
{
    public class RepositoryPeliculas
    {
        public PeliculasContext context;

        public RepositoryPeliculas(PeliculasContext context)
        {
            this.context = context;
        }

        public async Task<List<Pelicula>> GetPeliculasAsync()
        {
            return await this.context.Peliculas.ToListAsync();
        }
        public async Task<Pelicula> FindPeliculaAsync(int idPelicula)
        {
            return await this.context.Peliculas.FirstOrDefaultAsync(x => x.IdPelicula == idPelicula);
        }
        public async Task InsertarPeliculaAsync (Pelicula peli)
        {            
            this.context.Peliculas.Add(peli);
            await this.context.SaveChangesAsync();
        }
        public async Task UpdatePeliculaAsync(Pelicula peli)
        {
            this.context.Peliculas.Update(peli);
            await this.context.SaveChangesAsync();
        }
        public async Task DeletePeliculaAsync(int id)
        {
            Pelicula peli = await this.FindPeliculaAsync(id);
            this.context.Peliculas.Remove(peli);
            await this.context.SaveChangesAsync();
        }
        public async Task<List<Genero>> GetGenerosAsync()
        {
            return await this.context.Generos.ToListAsync();
        }
        public async Task<Genero> FindGeneroAsync(int idGenero)
        {
            return await this.context.Generos.FirstOrDefaultAsync(x => x.IdGenero == idGenero);
        }
        public async Task<List<Pelicula>> GetPeliculasGenero(int idGenero)
        {
            return await this.context.Peliculas.Where(x => x.IdGenero == idGenero).ToListAsync();
        }

    }
}
