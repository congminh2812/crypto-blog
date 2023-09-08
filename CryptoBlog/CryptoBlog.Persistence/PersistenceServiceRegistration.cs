using CryptoBlog.Persistence.DbContext;
using CryptoBlog.Persistence.Repositories.Implements;
using CryptoBlog.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoBlog.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogAppContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("BlogAppConnectionString"));
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
