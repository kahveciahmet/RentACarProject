using Core.DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarDB>, ICarDal
    {
        public List<CarDto> GetCarDetails(int? carId = null)
        {
            using (RentACarDB context = new RentACarDB())
            {
                var carDetails = new List<CarDto>();

                var cars = context.Cars.ToList();
                var brands = context.Brands.ToList();
                var colors = context.Colors.ToList();

                foreach (var car in cars)
                {
                    if (carId != null && car.Id != carId.Value)
                    {
                        continue;
                    }

                    var brand = brands.FirstOrDefault(b => b.Id == car.BrandId);
                    var color = colors.FirstOrDefault(c => c.Id == car.ColorId);

                    if (brand != null && color != null)
                    {
                        var carDto = new CarDto
                        {
                            Id = car.Id,
                            BrandId = car.BrandId,
                            BrandName = car.BrandName,
                            ColorId = car.ColorId,
                            ColorName = car.ColorName,
                            DailyKmLimit = car.DailyKmLimit,
                            DailyPrice = car.DailyPrice,
                            Description = car.Description,
                            LicenseAge = car.LicenseAge,
                            ModelYear = car.ModelYear,
                            RenterAge = car.RenterAge,
                            SeatingCapacity = car.SeatingCapacity,
                            TransmissionType = car.TransmissionType,
                            IsActive = car.IsActive,
                            IsDeleted = car.IsDeleted,
                        };

                        carDetails.Add(carDto);

                        if (carId != null)
                        {
                            break;
                        }
                    }
                }

                return carDetails;
            }
        }
    }
}
