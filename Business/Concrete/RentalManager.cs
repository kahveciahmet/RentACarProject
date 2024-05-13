using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects;
using Core.Utilities;
using DataAccess;
using Entities;

namespace Business
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [SecuredOperation("rental.add,admin")]
        [TransactionScopeAspect]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var result = BusinessRules.Run(CheckRentalExistence(rental.Id));
            if (!result.IsSuccess)
                return new ErrorResult(Messages.ItemAlreadyExists);

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.ItemAdded);
        }

        [SecuredOperation("rental.delete,admin")]
        [TransactionScopeAspect]
        public IResult Delete(Rental rental)
        {
            var result = BusinessRules.Run(CheckRentalExistence(rental.Id));
            if (result.IsSuccess)
                return new ErrorResult(Messages.ItemNotExists);

            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.ItemDeleted);
        }

        [SecuredOperation("rental.update,admin")]
        [TransactionScopeAspect]
        public IResult Update(Rental rental)
        {
            var result = BusinessRules.Run(CheckRentalExistence(rental.Id));
            if (result.IsSuccess)
                return new ErrorResult(Messages.ItemNotExists);

            _rentalDal.Update(rental);
            return new SuccessResult(Messages.ItemUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(x => x.Id == id));
        }

        private IResult CheckRentalExistence(int rentalId)
        {
            var result = _rentalDal.GetAll(x => x.Id == rentalId);
            if (result.Any())
                return new ErrorResult(Messages.ItemAlreadyExists);
            else
                return new SuccessResult();
        }


    }
}
