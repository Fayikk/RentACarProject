using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal brandDal;
        public BrandManager(IBrandDal _brandDal)
        {
            brandDal = _brandDal;
        }
        public List<Brand> GetCarsByBrandId(int brandId)
        {
            return brandDal.GetAll(a => a.BrandId == brandId);
        }
    }
}
