using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImagesService
    {
        IResult Add(IFormFile formFile, CarImages carImage);
        IResult Update(IFormFile formFile, CarImages carImage);
        IResult Delete(CarImages carImage);
        IDataResult<List<CarImages>> GetAll();
        IDataResult<List<CarImages>> GetCarImagesByCarId(int carId);
        IDataResult<CarImages> GetById(int carImageId);


    }
}
