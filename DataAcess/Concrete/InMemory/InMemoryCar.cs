using DataAcess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Concrete.InMemory
{
    public class InMemoryCar : ICarDal
    {
        List<Car> _cars;
        public InMemoryCar() 
        {
            _cars = new List<Car>
            {
               new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = "150TL", Description ="Audi" },
               new Car { Id = 2, BrandId = 2, ColorId = 3, DailyPrice = "250TL", Description ="Bugatti" },
               new Car { Id = 3, BrandId = 3, ColorId = 3, DailyPrice = "450TL", Description ="Tofas" },
               new Car { Id = 4, BrandId = 4, ColorId = 2, DailyPrice = "550TL", Description ="Porsche" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById()
        {
            return _cars.Where(c=>c.Id == c.Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
