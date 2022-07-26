using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Infrastructure.Persistance.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly DmContext _context;

        private IMovieRepository _movie;

        private IActorRepository _actor;

        public IMovieRepository Movie
        {
            get {
                if (_movie == null)
                {
                    _movie = new MovieRepository(_context);
                }
                return _movie;
            }
        }

        public IActorRepository Actor
        {
            get
            {
                if (_actor == null)
                {
                    _actor = new ActorRepository(_context);
                }
                return _actor;
            }
        }

        public RepositoryWrapper(DmContext context)
        {
            this._context = context;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
