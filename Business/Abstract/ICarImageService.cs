using Core.Utilities;
using Entities;
using Microsoft.AspNetCore.Http;

namespace Business
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage carImage, int carId);
        IResult Delete(CarImage carImage);
        IResult Update(CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);

    }
}
