using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Please enter the writer name");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Please enter the writer surname");
            RuleFor(x => x.About).NotEmpty().WithMessage("Please enter the discraption about writer");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Please enter at least three characters");
            RuleFor(x => x.WriterName).MaximumLength(20).WithMessage("Please enter less than twenty characters");
            RuleFor(x => x.WriterName).NotEqual(string.Empty).WithMessage("Username or Password is not correct");
        }

    }
}
