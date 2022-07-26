using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Infrastructure.Persistance.Repository
{
    public class ActorRepository : RepositoryBase<Actor>, IActorRepository
    {

        public ActorRepository(DmContext context) : base(context)
        {
        }
        public void CreateActor(Actor actor)
        {
            Create(actor);
        }

        public void DeleteActor(Actor actor)
        {
            Delete(actor);
        }

        public async Task<Actor> GetActorByIdAsync(Guid actorId)
        {
            return await FindByCondition(actor => actor.Id.Equals(actorId))
                .FirstOrDefaultAsync();
        }

        public async Task<Actor> GetActorWithDetailsAsync(Guid actorId)
        {
            return await FindByCondition(actor => actor.Id.Equals(actorId))
                .Include(m => m.Movies)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllActorsAsync()
        {
            return await FindAll()
                .OrderBy(a => a.FullName)
                .ToListAsync();
        }

        public void UpdateActor(Actor actor)
        {
            Update(actor);
        }
    }
}
