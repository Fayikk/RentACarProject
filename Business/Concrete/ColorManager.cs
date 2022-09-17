using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Entities.Concrete.Color color)
        {
            _colorDal.Add(color);
           return new Result(true,Messages.SuccessMessages);
        }

        public void delete(Entities.Concrete.Color color)
        {
            _colorDal.Delete(color);
        }

        public IDataResult<List<Entities.Concrete.Color>> GetAll()
        {
            return new DataResult<List< Entities.Concrete.Color >>(_colorDal.GetAll(),true,Messages.SuccessMessages);
        }

        //public IDataResult<List<Color>> GetCarsByColorId(int colorId)
        //{
            
        //}

        public void Update(Entities.Concrete.Color color)
        {
            _colorDal.Update(color);
        }
        [ValidationAspect(typeof(ColorValidator))]

        IDataResult<List<Entities.Concrete.Color>> IColorService.GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Entities.Concrete.Color>>(_colorDal.GetAll(a => a.ColorId == colorId), Messages.SuccessMessages);
        }



        //public List<Color> GetCarsByColorId(int colorId)
        //{
        //    return _colorDal.GetAll(a => a.ColorId == colorId);
        //}


    }
}
