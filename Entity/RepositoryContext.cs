using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions contextOptions)
            :base(contextOptions)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}
