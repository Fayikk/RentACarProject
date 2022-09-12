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
        List<Brand> GetCarsByBrandId(int BrandId);

        //Add
        void add(Brand brand);
        //Delete
        void delete(Brand brand);
        //Update
        void Update(Brand brand);

        List<MixedDetailDto> GetMixedDetailDtos();
    }
}
