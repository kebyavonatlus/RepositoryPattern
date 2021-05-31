using Contracts;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace AccountOwner.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSQLServerContext(this IServiceCollection service, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:DefaultConnection"];
            service.AddDbContext<RepositoryContext>(x => x.UseSqlServer(connectionString));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}