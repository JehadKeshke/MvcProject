using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior : AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Please enter the category name");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Please enter the discraption");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Please enter at least three characters");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Please enter less than twenty characters");
        }
    }
}
