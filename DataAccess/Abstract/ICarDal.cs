using Core.DataAccess;
using Entities;

namespace DataAccess
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDto> GetCarDetails(int? carId);
    }
}
