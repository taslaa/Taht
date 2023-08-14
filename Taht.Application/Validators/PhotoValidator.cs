using FluentValidation;

using Taht.Core;

namespace Taht.Application
{
    public class PhotoValidator : AbstractValidator<PhotoUpsertDto>
    {
        public PhotoValidator()
        {
            RuleFor(p => p.Data).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}
