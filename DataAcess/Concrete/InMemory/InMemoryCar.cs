using DataAcess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Concrete.InMemory
{
    public class InMemoryCar : ICarDal
    {
        List<Cars> _cars;
        public InMemoryCar() 
        {
            _cars = new List<Cars>
            {
               new Cars { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = "150TL", Description ="Audi" },
               new Cars { CarId = 2, BrandId = 2, ColorId = 3, DailyPrice = "250TL", Description ="Bugatti" },
               new Cars { CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = "450TL", Description ="Tofas" },
               new Cars { CarId = 4, BrandId = 4, ColorId = 2, DailyPrice = "550TL", Description ="Porsche" }
            };
        }
        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAllById()
        {
            return _cars.Where(c=>c.CarId == c.CarId).ToList();
        }

        public List<Cars> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Cars car)
        {
            Cars carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
