using Core.DataAccess;
using Entities;

namespace DataAccess
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarDB>, IRentalDal
    {

    }
}
