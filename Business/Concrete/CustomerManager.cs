using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects;
using Core.Utilities;
using DataAccess;
using Entities;

namespace Business
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [SecuredOperation("customer.add,admin")]
        [TransactionScopeAspect]
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            var result = BusinessRules.Run(CheckCustomerExistence(customer.Id));
            if (!result.IsSuccess)
                return new ErrorResult(Messages.ItemAlreadyExists);

            _customerDal.Add(customer);
            return new SuccessResult(Messages.ItemAdded);
        }

        [SecuredOperation("customer.delete,admin")]
        [TransactionScopeAspect]
        public IResult Delete(Customer customer)
        {
            var result = BusinessRules.Run(CheckCustomerExistence(customer.Id));
            if (result.IsSuccess)
                return new ErrorResult(Messages.ItemNotExists);

            _customerDal.Delete(customer);
            return new SuccessResult(Messages.ItemDeleted);
        }

        [SecuredOperation("customer.update,admin")]
        [TransactionScopeAspect]
        public IResult Update(Customer customer)
        {
            var result = BusinessRules.Run(CheckCustomerExistence(customer.Id));
            if (result.IsSuccess)
                return new ErrorResult(Messages.ItemNotExists);

            _customerDal.Update(customer);
            return new SuccessResult(Messages.ItemUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(x => x.Id == id));
        }

        private IResult CheckCustomerExistence(int customerId)
        {
            var result = _customerDal.GetAll(x => x.Id == customerId);
            if (result.Any())
                return new ErrorResult(Messages.ItemAlreadyExists);
            else
                return new SuccessResult();
        }

    }
}
