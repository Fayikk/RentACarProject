using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImagesManager : ICarImagesService
    {
        ICarImagesDal _carImagesDal;
        public CarImagesManager(ICarImagesDal carImagesDal)
        {
            _carImagesDal = carImagesDal;
        }

        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult Add(IFormFile image, CarImages carImage)
        {
            // Business Rules
            var ruleResult = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));
            if (ruleResult != null)
            {
                return new ErrorResult(ruleResult.Message);
            }

            // Adding Image
            var imageResult = FileHelper.Add(image);
            carImage.ImagePath = imageResult.Message;
            if (!imageResult.Success)
            {
                return new ErrorResult(imageResult.Message);
            }
            _carImagesDal.Add(carImage);
            return new SuccessResult(Messages.SuccessMessages);
        }

        public IResult Delete(CarImages carImage)
        {
            // Deleting Image
            var carToBeDeleted = _carImagesDal.Get(c => c.Id == carImage.Id);
            if (carToBeDeleted == null)
            {
                return new ErrorResult(Messages.ErrorMessages);
            }
            FileHelper.Delete(carToBeDeleted.ImagePath);
            _carImagesDal.Delete(carImage);
            return new SuccessResult(Messages.SuccessMessages);
        }

        public IDataResult<List<CarImages>> GetAll()
        {
            return new DataResult<List<CarImages>>(_carImagesDal.GetAll(),true,Messages.CarImagesListed);
        }

        public IDataResult<CarImages> GetById(int carImageId)
        {
            return new SuccessDataResult<CarImages>(_carImagesDal.Get(cI => cI.Id == carImageId),Messages.SuccessMessages );
        }

        public IDataResult<List<CarImages>> GetCarImagesByCarId(int carId)
        {
            var data = _carImagesDal.GetAll(cI => cI.CarId == carId);
            if (data.Count == 0)
            {
                data.Add(new CarImages
                {
                    CarId = carId,
                    ImagePath = "C:\\Users\\fayik\\Desktop\\construction-company-website-template"
                });
            }
            return new SuccessDataResult<List<CarImages>>(data,Messages.SuccessMessages);
        }

        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult Update(IFormFile image, CarImages carImage)
        {
            // Updating Image
            var carToBeUpdated = _carImagesDal.Get(c => c.Id == carImage.Id);
            if (carToBeUpdated == null)
            {
                return new ErrorResult(Messages.CarImageDoesNotFound);
            }
            var imageResult = FileHelper.Update(image, carToBeUpdated.ImagePath);
            carImage.ImagePath = imageResult.Message;
            if (!imageResult.Success)
            {
                return new ErrorResult(imageResult.Message);
            }
            _carImagesDal.Update(carImage);
            return new SuccessResult(Messages.SuccessMessages);
        }

        // Business Rules
        private IResult CheckImageLimitExceeded(int carId)
        {
            var carImagesOfTheCar = _carImagesDal.GetAll(p => p.CarId == carId);
            if (carImagesOfTheCar.Count >= 5)
            {
                return new ErrorResult(Messages.ErrorMessages);
            }
            return new SuccessResult(true);
        }
    }
}

