using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImagesValidator : AbstractValidator<CarImages>
    {
        //Buraya eğer isterseniz gerekli validasyon kodları yazılacaktır.
        public class CarImageValidator : AbstractValidator<CarImages>
        {
            public CarImageValidator()
            {
                RuleFor(c => c.CarId).NotEmpty();
                //RuleFor(c => c.ImagePath).NotEmpty();
                RuleFor(c => c.Date).NotEmpty();
            }
        }
    }
}
