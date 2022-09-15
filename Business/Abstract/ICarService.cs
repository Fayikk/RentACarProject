using Core.Utilities.Results;
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
        IDataResult<List<Car>> GetAll();
        //List<Car> Add(Car entity);
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();

        //void add(Car car);
        IResult Deleted(Car car);
        IResult Updated(Car car);

        IResult Add(Car car);

    }
}
