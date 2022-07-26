using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Domain.Interfaces
{
    public interface IActorRepository : IRepositoryBase<Actor>
    {
        Task<IEnumerable<Actor>> GetAllOwnersAsync();
        Task<Actor> GetOwnerByIdAsync(Guid actorId);
        Task<Actor> GetOwnerWithDetailsAsync(Guid actorId);
        void CreateOwner(Actor actor);
        void UpdateOwner(Actor actor);
        void DeleteOwner(Actor actor);
    }
}
