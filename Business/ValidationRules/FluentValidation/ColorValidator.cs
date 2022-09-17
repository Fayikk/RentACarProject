using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.ColorId).NotEqual(0).WithMessage("Id 0 ile başlayamaz.");
            RuleFor(c => c.ColorName).Must(StartWithA);
        }
        private bool StartWithA(string Arg)
        {
            return Arg.StartsWith("A");
        }
    }
}
