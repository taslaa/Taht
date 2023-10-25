using FluentValidation;

using Taht.Core;

namespace Taht.Application
{
    public class ReviewValidator : AbstractValidator<ReviewUpsertDto>
    {
        public ReviewValidator()
        {
            RuleFor(p => p.UserId).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(p => p.ReviewRating).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(p => p.ReviewComment).NotNull().WithErrorCode(ErrorCodes.NotNull)
                .NotEmpty().WithErrorCode(ErrorCodes.NotEmpty);
            RuleFor(p => p.IsAnonymous).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}
