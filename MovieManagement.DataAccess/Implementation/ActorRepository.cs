using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(MovieManagementDbContext context) :base(context) { }

        public IEnumerable<Actor> GetActorsWithMovies()
        {
            var actorsWithMovies = _context.Actors.Include(a => a.Movies).ToList();
            return actorsWithMovies;
        }
    }
}
