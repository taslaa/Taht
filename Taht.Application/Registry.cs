using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

using Taht.Core;
using Taht.Application.Interfaces;

namespace Taht.Application
{
    public static class Registry
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAppointmentsService, AppointmentsService>();
            services.AddScoped<IPhotosService, PhotosService>();
            services.AddScoped<IReservationsService, ReservationsService>();
            services.AddScoped<IReviewsService, ReviewsService>();
            services.AddScoped<IServicesService, ServicesService>();
            services.AddScoped<IUsersService, UsersService>();
        }

        public static void AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<AppointmentUpsertDto>, AppointmentValidator>();
            services.AddScoped<IValidator<PhotoUpsertDto>, PhotoValidator>();
            services.AddScoped<IValidator<ReservationUpsertDto>, ReservationValidator>();
            services.AddScoped<IValidator<ReviewUpsertDto>, ReviewValidator>();
            services.AddScoped<IValidator<ServiceUpsertDto>, ServiceValidator>();
            services.AddScoped<IValidator<UserUpsertDto>, UserValidator>();
            services.AddScoped<IValidator<UserChangePasswordDto>, UserPasswordValidator>();
        }
    }
}
