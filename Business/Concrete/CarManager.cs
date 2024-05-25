using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects;
using Core.Utilities;
using DataAccess;
using Entities;

namespace Business
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add,admin")]
        [TransactionScopeAspect]
        [ValidationAspect(typeof(CarValidator))]
        //[CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            var result = BusinessRules.Run(CheckCarExistence(car.Id));
            if (!result.IsSuccess)
                return new ErrorResult(Messages.ItemAlreadyExists);

            _carDal.Add(car);
            return new SuccessResult(Messages.ItemAdded);
        }

        [SecuredOperation("car.delete,admin")]
        [TransactionScopeAspect]
        public IResult Delete(Car car)
        {
            var result = BusinessRules.Run(CheckCarExistence(car.Id));
            if (result.IsSuccess)
                return new ErrorResult(Messages.ItemNotExists);
            _carDal.Delete(car);
            return new SuccessResult(Messages.ItemDeleted);
        }

        [SecuredOperation("car.update,admin")]
        [TransactionScopeAspect]
        public IResult Update(Car car)
        {
            var result = BusinessRules.Run(CheckCarExistence(car.Id));
            if (result.IsSuccess)
                return new ErrorResult(Messages.ItemNotExists);
            _carDal.Update(car);
            return new SuccessResult(Messages.ItemDeleted);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());    
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x=>x.BrandId == id));
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.ColorId == id));
        }

        [CacheAspect]
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(x => x.Id == id));
        }

        public IDataResult<List<CarDto>> GetCarDetails(int? carId)
        {
            return new SuccessDataResult<List<CarDto>>(_carDal.GetCarDetails(carId));
        }

        private IResult CheckCarExistence(int carId)
        {
            var result = _carDal.GetAll(x => x.Id == carId);
            if (result.Any())
                return new ErrorResult(Messages.ItemAlreadyExists);
            else
                return new SuccessResult();
        }



    }
}
