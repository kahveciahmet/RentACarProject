using Business.Constants;
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

        public IResult Add(Brand brand)
        {
            if (brand == null)
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.ItemAdded);
            }
            return new ErrorResult(Messages.ItemAlreadyExists);
        }

        public IResult Delete(Brand brand)
        {
            if (brand == null)
            {
                return new ErrorResult(Messages.ItemNotExists);
            }
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.ItemDeleted);
        }
        public IResult Update(Brand brand)
        {
            if (brand == null)
            {
                return new ErrorResult(Messages.ItemNotExists);
            }
            _brandDal.Update(brand);
            return new SuccessResult(Messages.ItemUpdated);

        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.Id == id));
        }


    }
}
