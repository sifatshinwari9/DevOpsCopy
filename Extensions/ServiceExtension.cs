using DataAccess.Entities;
using DataAccess.IRepository;
using DataAccess.Repository;

namespace CovidDashboard.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<CovidData>, CovidDataRepository>();
            return services;
        }
    }
}
