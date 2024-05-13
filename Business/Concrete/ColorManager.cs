using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects;
using Core.Utilities;
using DataAccess;
using Entities;
using System.Drawing.Drawing2D;

namespace Business
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [SecuredOperation("color.add,admin")]
        [TransactionScopeAspect]
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            var result = BusinessRules.Run(CheckColorExistence(color.Id));
            if (!result.IsSuccess)
                return new ErrorResult(Messages.ItemAlreadyExists);

            _colorDal.Add(color);
            return new SuccessResult(Messages.ItemAdded);
        }

        [SecuredOperation("color.delete,admin")]
        [TransactionScopeAspect]
        public IResult Delete(Color color)
        {
            var result = BusinessRules.Run(CheckColorExistence(color.Id));
            if (result.IsSuccess)
                return new ErrorResult(Messages.ItemNotExists);

            _colorDal.Delete(color);
            return new SuccessResult(Messages.ItemDeleted);
        }

        [SecuredOperation("color.update,admin")]
        [TransactionScopeAspect]
        public IResult Update(Color color)
        {
            var result = BusinessRules.Run(CheckColorExistence(color.Id));
            if (result.IsSuccess)
                return new ErrorResult(Messages.ItemNotExists);

            _colorDal.Update(color);
            return new SuccessResult(Messages.ItemUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(x => x.Id == id));
        }

        private IResult CheckColorExistence(int colorId)
        {
            var result = _colorDal.GetAll(x => x.Id == colorId);
            if (result.Any())
                return new ErrorResult(Messages.ItemAlreadyExists);
            else
                return new SuccessResult();
        }


    }
}
