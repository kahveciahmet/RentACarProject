using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects;
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

        [SecuredOperation("carimage.add,admin")]
        [TransactionScopeAspect]
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            BusinessRules.Run(CheckCarImageLimit(carImage.CarId));
            FileHelper fileHelper = new FileHelper();
            carImage.ImagePath = fileHelper.Add(file, "wwwroot\\Images\\CarImages");
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.ItemAdded);
        }

        [SecuredOperation("carimage.delete,admin")]
        [TransactionScopeAspect]
        public IResult Delete(CarImage carImage)
        {
            FileHelper fileHelper = new FileHelper();
            fileHelper.Delete("wwwroot\\Images\\CarImages" + carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.ItemDeleted);
        }

        [SecuredOperation("carimage.update,admin")]
        [TransactionScopeAspect]
        public IResult Update(IFormFile file, CarImage carImage)
        {
            FileHelper fileHelper = new FileHelper();
            carImage.ImagePath = fileHelper.Update(file, "wwwroot\\Images\\CarImages" + carImage.ImagePath, "wwwroot\\Images\\CarImages");
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.ItemUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<CarImage>> GetAll()
        {
            CarImage carImage = new CarImage();
            BusinessRules.Run(CheckIfCarImageNull(carImage.CarId));
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            CarImage carImage = new CarImage();
            BusinessRules.Run(CheckIfCarImageNull(carImage.CarId));
            return new SuccessDataResult<CarImage>(_carImageDal.Get(x => x.Id == id));
        }

        private IResult CheckCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(c=>c.CarId == carId).Count;
            if (result > 5)
            {
                return new ErrorResult(Messages.ImageLimitExceeded);
            }
            return null;
        }

        private IResult CheckIfCarImageNull(int carId)
        {
            string path = @"Images\CarImages\default.jpg";

            var result = _carImageDal.GetAll(c => c.CarId == carId).Any();
            if (!result)
            {
                new List<CarImage> { new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now } };
                return new SuccessResult("Car image was empty,so instead default image added.");
            }
            return null;
        }

    }
}
