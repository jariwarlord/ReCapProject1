using DataAcess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal, IEfCarDal
    {
        public void Add(Cars entity)
        {
            using (CarDatabaseService context = new CarDatabaseService())
            {
                // Implement the logic to add a new car to the database
                // Example:
                // context.Cars.Add(entity);
                // context.SaveChanges();
            }
        }

        public void Delete(Cars entity)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            using (CarDatabaseService context = new CarDatabaseService())
            {
                return filter == null
                     ? context.Set<Cars>().ToList()
                     : context.Set<Cars>().Where(filter).ToList();
            }
        }

        public List<Cars> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Cars entity)
        {
            throw new NotImplementedException();
        }
    }
}
