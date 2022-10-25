using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using ImpromptuInterface;
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
        public List<CarDetail> GetByDetails()
        {
            using (RentCarsContext context = new RentCarsContext())
            {
                var result = from cr in context.Cars
                             join cl in context.Colors
                             on cr.ColorId equals cl.ColorId
                             join br in context.Brands
                             on cr.BrandId equals br.BrandId
                             select new CarDetail
                             {
                                 BrandName = br.BrandName,
                                 CarId = cr.CarId,
                                 CarName = cr.CarName,
                                 ColorId = cl.ColorId,
                                 ColorName = cl.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 ModelYear = cr.ModelYear

                             };
                return result.ToList();
            }
        }

        public CarDetail GetCarDetail(Expression<Func<Car, bool>> filter)
        {
            using (RentCarsContext context = new RentCarsContext())
            {
                var result = from cr in context.Cars.Where(filter)
                             join cl in context.Colors
                             on cr.ColorId equals cl.ColorId
                             join br in context.Brands
                             on cr.BrandId equals br.BrandId

                             select new CarDetail
                             {
                                 BrandName = br.BrandName,
                                 CarId = cr.CarId,
                                 CarName = cr.CarName,
                                 ColorId = cr.ColorId,
                                 ColorName = cl.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 CarImage = context.CarImages.Where(ci => ci.CarId == cr.CarId).ToList()
                             };
                return result.FirstOrDefault();
            }
        }



        public List<CarDetailDto> GetCarDetailDtos()
        {
            //Öncellikle veri tabanında işlem yaptığımzı belirtmemiz gerekmektedir.
            //Bunun içindirki using kullanımı gerçekleştiriyoruz.
            using (RentCarsContext context = new RentCarsContext())
            {
                //değeri döndürmek için bir geçici değişkene ifadelerimizi aktaralim.
                var result = from c in context.Cars //Arabaların dbo'sunu çekiyoeuz.
                             join b in context.Brands // brands veritabanını çekiyoruz.
                                                      //Şimdi koşul yazıyoruz.Koşulumuz geçerli ise devam ettirme işlemi 
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto { BrandId = b.BrandId, BrandName = b.BrandName, CarName = c.CarName, CarId = c.CarId };
                return result.ToList();
            }
        }
        //Her üç tabloyuda yazdırabilecek bir join işlemi ile kod işlemi gerçekleştirelim.
        //




    }
}
