using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAcces.Abstract;
using DataAcces.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _ıcarDal;

        public CarManager(ICarDal ıcarDal)
        {
            _ıcarDal = ıcarDal;
        }

        //public void add(Car car)
        //{
        //    _ıcarDal.Add(car);
        //}
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            if (car.CarName.Length>2)
            {
                //magic string
                _ıcarDal.Add(car);
                return new SuccessResult(Messages.SuccessMessages);
            }
            return new ErrorResult(Messages.ErrorMessages); 
        }

        public IResult Deleted(Car car)
        {
            _ıcarDal.Delete(car);
            return new Result(true);
        }

        //public List<Car> Add(Car entity)
        //{
        //    return _ıcarDal.Add(entity).ToList();
        //}

        public IDataResult<List<Car>> GetAll()
        {
            return new DataResult<List<Car>>(_ıcarDal.GetAll(),true,Messages.SuccessMessages);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            return new DataResult<List<CarDetailDto>>(_ıcarDal.GetCarDetailDtos(),true,Messages.SuccessMessages);
        }

        public IResult Updated(Car car)
        {
            if (car.CarName.Length>2)
            {
                return new ErrorResult(Messages.ErrorMessages);
            }
            _ıcarDal.Update(car);
            return new SuccessResult(Messages.SuccessMessages);
        }
    }
}
