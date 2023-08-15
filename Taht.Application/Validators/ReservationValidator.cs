using FluentValidation;

using Taht.Core;

namespace Taht.Application
{
    public class ReservationValidator : AbstractValidator<ReservationUpsertDto>
    {
        public ReservationValidator()
        {
            RuleFor(p => p.UserId).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(p => p.ServiceId).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(p => p.ReservationDate).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(p => p.GuestCount).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}
