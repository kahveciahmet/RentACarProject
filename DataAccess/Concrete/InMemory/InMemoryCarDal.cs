using Entities;
using System.Linq.Expressions;

namespace DataAccess
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            List<Car> cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1 ,DailyPrice = 3700, ModelYear = new DateTime(2024,1,1),Description="BMW 420i 2024 Model" },
                new Car { Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 4000, ModelYear = new DateTime(2024,1,1),Description="BMW 520i 2024 Model" },
                new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 3500, ModelYear = new DateTime(2023,6,20),Description="Mercedes C180 2023 Model" },
                new Car { Id = 4, BrandId = 3, ColorId = 1, DailyPrice = 2250, ModelYear = new DateTime(2016,1,1),Description="Ford Courier 2016 Model" },
                new Car { Id = 5, BrandId = 3, ColorId = 1, DailyPrice = 1700, ModelYear = new DateTime(2016,1,1),Description="Fiat FioRino 2016 Model" },
            };
        }
        public void Add(Car car)
        {
            if (car.Description?.Length > 2 && car.DailyPrice > 0)
            {
                _cars.Add(car);
            }
            else
            {
                throw new ArgumentException("Araba ismi minimum 2 karakter olmalıdır ve günlük fiyat 0dan büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            var result = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(result);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(x => x.Id == id).ToList();
        }

        public List<CarDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _cars.Where(x=>x.BrandId == brandId).ToList();
        }
        
        public List<Car> GetCarsByColorId(int colorId)
        {
            return _cars.Where(x=>x.ColorId == colorId).ToList();
        }



        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
