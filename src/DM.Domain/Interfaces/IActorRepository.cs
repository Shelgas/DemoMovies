using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Domain.Interfaces
{
    public interface IActorRepository : IRepositoryBase<Actor>
    {
        Task<IEnumerable<Actor>> GetAllActorsAsync();
        Task<Actor> GetActorByIdAsync(Guid actorId);
        Task<Actor> GetActorWithDetailsAsync(Guid actorId);
        void CreateActor(Actor actor);
        void UpdateActor(Actor actor);
        void DeleteActor(Actor actor);
    }
}
