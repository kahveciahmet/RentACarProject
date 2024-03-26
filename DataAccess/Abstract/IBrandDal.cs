using Entities;

namespace DataAccess
{
    public interface IBrandDal
    {
        List<Brand> GetAll();
        List<Brand> GetById(int id);
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}
