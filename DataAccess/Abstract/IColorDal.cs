using Entities;

namespace DataAccess
{
    public interface IColorDal
    {
        List<Color> GetAll();
        List<Color> GetById(int id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
