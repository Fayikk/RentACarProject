using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using DataAcces.Concrete;
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

        public IResult add(Brand brand)
        {
            brandDal.Add(brand);
            return new Result(true);
        }

        public IResult delete(Brand brand)
        {
            brandDal.Delete(brand);
        
            return new Result(true);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new DataResult<List<Brand>>(brandDal.GetAll(),true,Messages.SuccessMessages);
        }

        public IDataResult<List<Brand>> GetCarsByBrandId(int BrandId)
        {
            
            if (false)
            {
                return new SuccessDataResult<List<Brand>>(brandDal.GetAll(b => b.BrandId == BrandId));
            }
            return new ErrorDataResult<List<Brand>>(Messages.ErrorMessages);
            
        }

        public IDataResult<List<MixedDetailDto>> GetMixedDetailDtos()
        {
            return new DataResult<List<MixedDetailDto>>(brandDal.GetMixedDetailDto(),true,Messages.SuccessMessages);
        }

        public IResult Update(Brand brand)
        {
            brandDal.Update(brand);
            return new Result(true,Messages.SuccessMessages);
        }
    }
}
