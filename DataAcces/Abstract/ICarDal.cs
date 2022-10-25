using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        //join ifadeleri için gerekli tanımlamaları gerçekleştirelim.
        //Class'a özgü ifadeleri buraya yazıyoruz.
        //Aşağıda görüldüğü üzere class'a özgü uygulamak istediğimiz ifadeleri yazıyoruz.
        //List<CarDetailDto> GetCarDetailDtos();
        List<CarDetailDto> GetCarDetailDtos();
     CarDetail  GetCarDetail(Expression<Func<Car, bool>> filter);

        List<CarDetail> GetByDetails();

    }
}
