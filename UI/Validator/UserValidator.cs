using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using SquadManager.Models;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() {
            RuleFor(user => user.Email).NotNull().WithMessage("Email field is empty");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Invalid email");
            RuleFor(user => user.Password).NotNull().WithMessage("Type password");
        }
    }
}