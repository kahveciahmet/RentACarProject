using Entities;

namespace Business
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        List<Car> GetAllByBrandId(int id);
        List<CarDto> GetCarDetails();
    }
}
