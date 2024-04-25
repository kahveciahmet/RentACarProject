using Core.DataAccess;
using Entities;

namespace DataAccess
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarDB>, ICustomerDal
    {

    }
}
