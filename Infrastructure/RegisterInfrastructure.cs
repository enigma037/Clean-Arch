using Application.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class RegisterInfrastructure
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                           IConfiguration configuration)
        {
            services.AddDbContext<IEDbContext, EDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ECOM"));
            });

            return services;
        }
    }
}
