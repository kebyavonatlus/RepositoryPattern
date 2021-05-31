using Contracts;
using Entity;
using Entity.Models;

namespace Repository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {

        }
    }
}