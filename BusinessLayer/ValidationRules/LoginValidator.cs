using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class LoginValidator : AbstractValidator<Admin>
    {
        public LoginValidator()
        {
            
        }
    }
}
