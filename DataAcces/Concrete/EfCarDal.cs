using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarsContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            //Öncellikle veri tabanında işlem yaptığımzı belirtmemiz gerekmektedir.
            //Bunun içindirki using kullanımı gerçekleştiriyoruz.
            using (RentCarsContext context = new RentCarsContext())
            {
                 //değeri döndürmek için bir geçici değişkene ifadelerimizi aktaralim.
                 var result=from c in context.Cars //Arabaların dbo'sunu çekiyoeuz.
                            join b in context.Brands // brands veritabanını çekiyoruz.
                            //Şimdi koşul yazıyoruz.Koşulumuz geçerli ise devam ettirme işlemi 
                            on c.BrandId equals b.BrandId
                            select new CarDetailDto { BrandId=b.BrandId,BrandName=b.BrandName,CarName=c.CarName,CarId=c.CarId};
                            return result.ToList();
              }
        }
    }
}
