﻿using FluentValidation;

using Taht.Core;

namespace Taht.Application
{
    public class UserPasswordValidator : AbstractValidator<UserChangePasswordDto>
    {
        public UserPasswordValidator()
        {
            RuleFor(u => u.NewPassword)
                .NotEmpty()
                .NotNull()
                .MinimumLength(8)
                .Matches(@"[A-Z]+")
                .Matches(@"[0-9]+")
                .WithErrorCode(ErrorCodes.InvalidValue);

            RuleFor(u => u.ConfirmNewPassword)
                .Equal(u => u.NewPassword)
                .WithErrorCode(ErrorCodes.InvalidValue);
        }
    }
}
