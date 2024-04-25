using Core.DataAccess;
using Entities;

namespace DataAccess
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentACarDB>, IUserDal
    {

    }
}
