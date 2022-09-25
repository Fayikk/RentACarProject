using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        //Construvtor oluşturalım ve class çağrıldığı zaman tetiklenmesini sağlayalım.
        public CarValidator()
        {
            //Burada Add metodu için validator hazırladığımızı varsayalım.
            //RuleFor(c => c.CarName).Must(StartWithF).WithMessage("Ürün adı  'F' ile başlamalı");
            //RuleFor(c => c.ModelYear).NotEmpty();
            //RuleFor(c => c.DailyPrice).GreaterThan(10000);
            ////Görüldüğü üzere burada validator kodlar yazılmaktadır.
        
        
        }
        private bool StartWithF(string arg)
        {
            return arg.StartsWith("F");
        }
    }
}
