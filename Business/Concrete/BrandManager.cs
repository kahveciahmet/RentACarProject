using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects;
using Core.Utilities;
using DataAccess;
using Entities;

namespace Business
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [SecuredOperation("brand.add,admin")]
        [TransactionScopeAspect]
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            var result = BusinessRules.Run(CheckBrandExistence(brand.Id));
            if (!result.IsSuccess)
                return new ErrorResult(Messages.ItemAlreadyExists);

            _brandDal.Add(brand);
            return new SuccessResult(Messages.ItemAdded);
        }

        [SecuredOperation("brand.delete,admin")]
        [TransactionScopeAspect]
        public IResult Delete(Brand brand)
        {
            var result = BusinessRules.Run(CheckBrandExistence(brand.Id));
            if (result.IsSuccess)
                return new ErrorResult(Messages.ItemNotExists);

            _brandDal.Delete(brand);
            return new SuccessResult(Messages.ItemDeleted);
        }

        [SecuredOperation("brand.update,admin")]
        [TransactionScopeAspect]
        public IResult Update(Brand brand)
        {
            var result = BusinessRules.Run(CheckBrandExistence(brand.Id));
            if (result.IsSuccess)
                return new ErrorResult(Messages.ItemNotExists);

            _brandDal.Update(brand);
            return new SuccessResult(Messages.ItemUpdated);

        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.Id == id));
        }

        private IResult CheckBrandExistence(int brandId)
        {
            var result = _brandDal.GetAll(x => x.Id == brandId);
            if (result.Any())
                return new ErrorResult(Messages.ItemAlreadyExists);
            else
                return new SuccessResult();
        }

    }
}
