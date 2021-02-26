using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { CarId = 1, BranId = 1, ColorId = 1, DailyPrice = 25000, Description = "6 Sitzer" , ModelYear = 2019 },
                new Car { CarId = 2, BranId = 1, ColorId = 2, DailyPrice = 15000, Description = "5 Sitzer" , ModelYear = 2019 },
                new Car { CarId = 3, BranId = 2, ColorId = 3, DailyPrice = 75000, Description = "4 Sitzer" , ModelYear = 2020 },
                new Car { CarId = 4, BranId = 2, ColorId = 4, DailyPrice = 25000, Description = "2 Sitzer" , ModelYear = 2021 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);           
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByCarId(int CarId)
        {
            return _cars.Where(p => p.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BranId = car.BranId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
