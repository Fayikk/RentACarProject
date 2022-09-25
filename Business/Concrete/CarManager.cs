using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
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
using static Core.Utilities.Business.BusinessRules;

namespace Business.Concrete
{   //İş kodlarını yazalım
    public class CarManager : ICarService
    {
        //Mikroservis kulllanalım.
        //Eklenen elemanın BrandId'sini kontrol edelim.Bunun için BrandService için mikroservis oluşturalım.
        ICarDal _ıcarDal;
        IBrandService _brandService;

        public CarManager(ICarDal ıcarDal, IBrandService brandService)
        {
            _ıcarDal = ıcarDal;
            _brandService = brandService;
            //Mikro servis yapısı için temel olarak yapımızı oluşturduk
        }

        //public void add(Car car)
        //{
        //    _ıcarDal.Add(car);
        //}
        [SecuredOperation("car.add")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //Aynı isimde ürün ekleme işlemini engelleyelim.

            IResult result = BusinessRules.Run(CheckNameControl(car.CarName), CheckIdControl(car.CarId));//Burada iş sınıfı kodlarımızı tutuyoruz.
            if (result != null)
            {
                return result;
            }
            _ıcarDal.Add(car);
            return new SuccessResult(Messages.SuccessMessages);
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
            return new DataResult<List<Car>>(_ıcarDal.GetAll(),true);
        }

        public IDataResult<List<Car>> GetById(int Id)
        {
            return new DataResult<List<Car>>(_ıcarDal.GetAll(ı => ı.CarId == Id), true, Messages.SuccessMessages);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            return new DataResult<List<CarDetailDto>>(_ıcarDal.GetCarDetailDtos(), true, Messages.SuccessMessages);
        }

        public IResult Updated(Car car)
        {
            if (car.CarName.Length > 2)
            {
                return new ErrorResult(Messages.ErrorMessages);
            }
            _ıcarDal.Update(car);
            return new SuccessResult(Messages.SuccessMessages);
        }

        private IResult CheckNameControl(string CarName)
        {
            var result = _ıcarDal.GetAll(c => c.CarName == CarName).Any();//Buradaki Any aynımı anlamına gelmektedir.
            if (result)
            {
                return new ErrorResult(false);
            }
            return new SuccessResult(true);
        }

        private IResult CheckIdControl(int carId)
        {
            var result = _ıcarDal.GetAll(a => a.CarId == carId).Any();
            if (result)
            {
                return new ErrorResult(false);
            }
            return new SuccessResult(true);
        }

        private IResult CheckControlBrandId()
        {
            var result = _brandService.GetAll();
            if (result.Data.Count > 10)
            {
                return new ErrorResult(false);//Kontrol işlemlerinden sonra error ise hata döndürelim
            }
            return new SuccessResult(true);

        }
    }
}
