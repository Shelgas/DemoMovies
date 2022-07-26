using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Infrastructure.Persistance.Repository
{
    public class MovieRepository : RepositoryBase<Movie>,  IMovieRepository 
    {
        public MovieRepository(DmContext context) : base(context)
        {
        }

        public void CreateMovie(Movie movie)
        {
            Create(movie);
        }

        public void DeleteMovie(Movie movie)
        {
            Delete(movie);
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await FindAll()
                .OrderBy(ow => ow.Name)
                .ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(Guid movieId)
        {
            return await FindByCondition(movie => movie.Id.Equals(movieId))
            .FirstOrDefaultAsync();
        }

        public async Task<Movie> GetMovieWithDetailsAsync(Guid movieId)
        {
            return await FindByCondition(movie => movie.Id.Equals(movieId))
            .Include(ac => ac.Actors)
            .FirstOrDefaultAsync();
        }

        public void UpdateMovie(Movie movie)
        {
            Update(movie);
        }
    }
}
