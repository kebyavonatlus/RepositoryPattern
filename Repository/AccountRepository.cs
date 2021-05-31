using Contracts;
using Entity;
using Entity.Models;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {

        }
    }
}