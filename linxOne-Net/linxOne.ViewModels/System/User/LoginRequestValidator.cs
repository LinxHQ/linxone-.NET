using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModels.System.User
{
   public class LoginRequestValidator: AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User Name is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                                    .MinimumLength(6).WithMessage("Password is least 6 character");
        }
    }
}
