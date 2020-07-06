using FluentValidation;
using Students.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Core.Validator
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator() {
            RuleFor(x => x.StudentId).NotNull().WithMessage("El nombre no puede ser vacío");
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.Email).EmailAddress().NotNull();
            RuleFor(x => x.Age).GreaterThan(0).LessThan(30).NotNull();
            RuleFor(x => x.Gender).NotNull();
            RuleFor(x => x.Grade).GreaterThan(0).LessThan(7).NotNull();
        }
    }
}
