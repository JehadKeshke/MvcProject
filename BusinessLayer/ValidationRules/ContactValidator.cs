using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Please enter the user name");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Please enter the Mail");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Please enter the Subject");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Please enter the Message");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Please enter at least three characters");
            RuleFor(x => x.Subject).MaximumLength(30).WithMessage("Please enter less than twenty characters");
        }

    }
}
