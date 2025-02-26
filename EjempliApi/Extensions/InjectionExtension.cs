using EjempliApi.Application.Interfaces;
using EjempliApi.Application.Services;
using EjempliApi.Infrastructure.Context;
using EjempliApi.Infrastructure.Persistence.Interfaces;
using EjempliApi.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EjempliApi.Extensions
{
    public static class InjectionExtension
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(DbaeroClubContext).Assembly.FullName;

            services.AddDbContext<DbaeroClubContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("POSConnection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient
                    );

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IPersona, PersonaService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            return services;
        }
    }
}
