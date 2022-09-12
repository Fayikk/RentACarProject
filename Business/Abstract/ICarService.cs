using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        //List<Car> Add(Car entity);
        List<CarDetailDto> GetCarDetailDtos();

        void add(Car car);
        void Deleted(Car car);
        void Updated(Car car);
    }
}
