using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {

        public BrandValidator()
        {
            RuleFor(b => b.BrandId).NotEqual(0).WithMessage("Id '0' olamaz");//BrandId'i 0'a eşit olamaz.
            RuleFor(b => b.BrandName).NotEmpty();//Marka adı boş olamaz.
        }


    }
}
