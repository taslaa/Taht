using FluentValidation;

using Taht.Core;

namespace Taht.Application
{
    public class AppointmentValidator : AbstractValidator<AppointmentUpsertDto>
    {
        public AppointmentValidator()
        {
            RuleFor(p => p.AppointmentDate).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(p => p.AppointmentTime).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(p => p.IsBooked).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}
