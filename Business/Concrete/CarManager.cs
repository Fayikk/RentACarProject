using Business.Abstract;
using DataAcces.Abstract;
using DataAcces.Concrete;
using Entities.Concrete;
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

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _ıcarDal.Add(car);
                Console.WriteLine("Eklendi..");
            }
            else
            {
                Console.WriteLine("Eklenemedi");
            }
        }

        public List<Car> GetAll()
        {
            return _ıcarDal.GetAll();
        }
    }
}
