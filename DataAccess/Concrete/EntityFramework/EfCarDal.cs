using Core.DataAccess;
using Entities;

namespace DataAccess
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarDB>, ICarDal
    {
        public List<CarDto> GetCarDetails()
        {
            using (RentACarDB context = new RentACarDB())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join x in context.Colors on c.ColorId equals x.Id
                             select new CarDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ColorName = x.Name,
                                 DailyPrice = c.DailyPrice,
                                 Name = c.Description,
                             };

                return result.ToList();
            }
        }
    }
}
