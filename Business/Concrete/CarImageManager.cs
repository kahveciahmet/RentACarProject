﻿using Business.Constants;
using Core.Utilities;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;

namespace Business
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = ImageHelper.AddImage(file, "carimages");
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.ItemAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", carImage.ImagePath);
            if (File.Exists(imagePath))
            {
                _carImageDal.Delete(carImage);
                return new SuccessResult(Messages.ItemDeleted);
            }
            return new ErrorResult();
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.ItemUpdated);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(x => x.Id == id));
        }

        
    }
}