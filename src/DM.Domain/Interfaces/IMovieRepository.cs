global using DM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Domain.Interfaces
{
    public interface IMovieRepository : IRepositoryBase<Movie>
    {
        Task<IEnumerable<Movie>> GetAllOwnersAsync();
        Task<Movie> GetOwnerByIdAsync(Guid movieId);
        Task<Movie> GetOwnerWithDetailsAsync(Guid movieId);
        void CreateOwner(Movie movie);
        void UpdateOwner(Movie movie);
        void DeleteOwner(Movie movie);
    }
}
