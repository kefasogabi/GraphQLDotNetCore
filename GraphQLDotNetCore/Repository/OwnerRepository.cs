using GraphQLDotNetCore.Contracts;
using GraphQLDotNetCore.Entities.Context;

namespace GraphQLDotNetCore.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationContext _context;

        public OwnerRepository(ApplicationContext context)
        {
            _context = context;
        }
    }
}
