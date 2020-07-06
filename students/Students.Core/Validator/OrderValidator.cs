using FluentValidation;
using Students.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Core.Validator
{
    public class OrderValidator: AbstractValidator<Order>
    {
        public OrderValidator() {
            RuleFor(x => x.Description).NotNull().MaximumLength(300);
            RuleFor(x => x.AmountTotal).NotNull().GreaterThan(0);
            RuleFor(x => x.StudentId).NotNull();
        }
    }
}
