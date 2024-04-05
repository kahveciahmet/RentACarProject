using DataAccess;
using Entities;

namespace Business
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();    
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(x=>x.BrandId == id);
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(x=>x.Id == id);
        }

        public List<CarDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
