using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Concrete.EntityFramework
{
    public interface IEfCarDal
    {
        List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null);
        void Add(Cars entity);
        void Update(Cars entity);
        void Delete(Cars entity);
        List<Cars> GetCarsByBrandId(int brandId);
        List<Cars> GetCarsByColorId(int colorId);
    }
}
