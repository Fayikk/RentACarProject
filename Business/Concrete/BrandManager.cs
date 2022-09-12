using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public void add(Brand brand)
        {
            brandDal.Add(brand);
        }

        public void delete(Brand brand)
        {
            brandDal.Delete(brand);
        }

        public List<Brand> GetCarsByBrandId(int BrandId)
        {
            return brandDal.GetAll(b=>b.BrandId==BrandId);
        }

        public List<MixedDetailDto> GetMixedDetailDtos()
        {
            return brandDal.GetMixedDetailDto();
        }

        public void Update(Brand brand)
        {
            brandDal.Update(brand);
        }
    }
}
