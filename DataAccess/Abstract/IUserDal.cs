using Core.DataAccess;
using Core.Entities;

namespace DataAccess
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
