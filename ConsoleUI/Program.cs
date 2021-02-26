using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("----- Actual --- Car List --------------------");
            Console.WriteLine("Car ID  " + "  Car Marke" + "   Car Color " + " Car Price " + "   Car Description " + "     Car Model Year");
            foreach (var car in carManager.GetAll())
            {  
                Console.WriteLine("   " +car.CarId + "          " + car.BranId + "           "         + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
            }
            
            Console.WriteLine("----- Actual --- Car ID 3 --------------------");
            int id = 3;
            foreach (var car in carManager.GetByCarId(id))
            {
                Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
            }
            
            Console.WriteLine("----- Update --- Car ID 3 --------------------");
            carManager.Update(new Car { CarId = id, BranId = 3, ColorId = 3, DailyPrice = 12000, ModelYear = 2000, Description = "7 Sitzer" });
            Console.WriteLine(" CarId = id, BranId = 3, ColorId = 3, DailyPrice = 12000, ModelYear = 2000, Description = 7 Sitzer");
            Console.WriteLine("----- After Update --- Car List --------------------");
            foreach (var car in carManager.GetAll())
            {  
                Console.WriteLine("   " +car.CarId + "          " + car.BranId + "           "         + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
            }
            Console.WriteLine("----- Add --- New Car --------------------");
            carManager.Add(new Car { CarId = 5, BranId = 2, ColorId = 1, DailyPrice = 19900, ModelYear = 2015, Description = "3 Sitzer" });
            Console.WriteLine("CarId = 5, BranId = 2, ColorId = 1, DailyPrice = 19900, ModelYear = 2015, Description = 3 Sitzer");
            Console.WriteLine("----- After Add --- Car List --------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
            }
            id = 4;
            Console.WriteLine("----- Delete --- Car --------------------");
            carManager.Delete(new Car { CarId = id });
            Console.WriteLine(" Delete CarId 4 ");
            Console.WriteLine("----- After Delete --- Car List --------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
            }
        }
    }
}

