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
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentCarsContext>, IBrandDal
    {
        public List<MixedDetailDto> GetMixedDetailDto()
        {
            using (RentCarsContext context = new RentCarsContext())
            {
                var result = from b in context.Brands
                             join c in context.Cars
                             on b.BrandId equals c.BrandId
                             join d in context.Colors
                             on c.ColorId equals d.ColorId
                             select new MixedDetailDto { BrandName = b.BrandName, CarName = c.CarName,
                                 ColorName = d.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
