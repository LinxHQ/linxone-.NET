using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModels.System.User
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {

        public RegisterRequestValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("User Name is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("User Name is required");

            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required")
                .MaximumLength(200).WithMessage("First name can not over 200 characters");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required")
                .MaximumLength(200).WithMessage("Last name can not over 200 characters");


            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                .WithMessage("Email format not match");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone number is required");


            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password is at least 6 characters")
                .Matches("[A-Z]").WithMessage("PasswordUppercaseLetter")
                .Matches("[a-z]").WithMessage("PasswordLowercaseLetter")
                .Matches("[0-9]").WithMessage("PasswordNumberDigit")
                .Matches("[!@#$%&*]").WithMessage("PasswordSpecialCharacter(!@#$%&*)");

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("Confirm password is not match");
                }
            });
        }
    }
}
