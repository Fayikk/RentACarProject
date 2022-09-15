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
    public interface IBrandService
    {
        //Crud operasyonlarını buraya yazabiliriz.(Ekleme,Silme,Güncelleme operasyonları)
        IDataResult<List<Brand>> GetCarsByBrandId(int BrandId);
        IDataResult<List<Brand>> GetAll();
        //Add
        IResult add(Brand brand);
        //Delete
        IResult delete(Brand brand);
        //Update
        IResult Update(Brand brand);

        IDataResult<List<MixedDetailDto>> GetMixedDetailDtos();
    }
}
