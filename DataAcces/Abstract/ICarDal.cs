using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        //join ifadeleri için gerekli tanımlamaları gerçekleştirelim.

        List<CarDetailDto> GetCarDetailDtos();


    }
}
