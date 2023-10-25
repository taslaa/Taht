using FluentValidation;

using Taht.Core;

namespace Taht.Application
{
    public class ServiceValidator : AbstractValidator<ServiceUpsertDto>
    {
        public ServiceValidator()
        {
            RuleFor(p => p.Name).NotNull().WithErrorCode(ErrorCodes.NotNull)
                .NotEmpty().WithErrorCode(ErrorCodes.NotEmpty);
            RuleFor(p => p.Description).NotNull().WithErrorCode(ErrorCodes.NotNull)
                .NotEmpty().WithErrorCode(ErrorCodes.NotEmpty);
            RuleFor(p => p.Price).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}

