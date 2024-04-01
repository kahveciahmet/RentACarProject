using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentACarContextDB db = new RentACarContextDB())
            {
                var addedEntity = db.Add(entity);
                addedEntity.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentACarContextDB db = new RentACarContextDB())
            {
                var deletedEntity = db.Add(entity);
                deletedEntity.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContextDB db = new RentACarContextDB())
            {
                return db.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
