using Microsoft.Extensions.DependencyInjection;

using Taht.Infrastructure.Interfaces;

namespace Taht.Infrastructure
{
    public static class Registry
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IReservationsRepository, ReservationsRepository>();
            services.AddScoped<IReviewsRepository, ReviewsRepository>();
            services.AddScoped<IServicesRepository, ServicesRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
