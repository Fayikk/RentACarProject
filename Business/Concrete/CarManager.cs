using Business.Abstract;
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

        public void add(Car car)
        {
            _ıcarDal.Add(car);
        }

        public void Deleted(Car car)
        {
            _ıcarDal.Delete(car);
        }

        //public List<Car> Add(Car entity)
        //{
        //    return _ıcarDal.Add(entity).ToList();
        //}

        public List<Car> GetAll()
        {
            return _ıcarDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            return _ıcarDal.GetCarDetailDtos();
        }

        public void Updated(Car car)
        {
            _ıcarDal.Update(car);
        }
    }
}
