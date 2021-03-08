using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarGetAll();
            //CarAdd();
            //CarGetAll();
            //CarUpdate();
            //CarGetAll();
            //CarGetByID(4);
            //CarDelete(4);
            //CarGetAll();

            //BrandgetAll();
            //BrandGetById(2);
            //ColorGetAll();
            //ColorGetById(2);

            CarGetDetail();

        }

        private static void CarGetDetail()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("----  CarGetDetail--");
            Console.WriteLine("Car ID  " + "  Car Marke" + "    Car Color " );
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("   " + car.CarId + "      " + car.BrandName + "           " + car.ColorName);
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("-------------------------------------");
        }

        private static void CarDelete(int id)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("----  CarDelete--");
            carManager.Delete(new Car { CarId = id });
            Console.WriteLine("CarId 4 -- Delete");
            Console.WriteLine("-------------------------------------");
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("----  CarUpdate--");
            carManager.Update(new Car { CarId = 4, BrandId = 2, ColorId = 2, DailyPrice = 1500, Description = "3 Sitzer", ModelYear = 2015 });
            Console.WriteLine("CarId 4 -- new DailyPrice 1500");
            Console.WriteLine("-------------------------------------");
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("----  CarAdd--");
            carManager.Add(new Car { CarId = 4, BrandId = 2, ColorId = 2, DailyPrice = 999999, Description = "3 Sitzer", ModelYear = 2015 });
            Console.WriteLine("CarId 4 -- BrandId 2 -- ColorId2 -- DailyPrice 999999 -- Description 3 Sitzer -- ModelYear = 2015");
            Console.WriteLine("-------------------------------------");
        }

        private static void BrandGetById(int id)
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            Console.WriteLine("---- BrandGetById--");
            Console.WriteLine("BrandID  " + "  Brandname");

            foreach (var brand in brandManager.GetById(id))
            {

                Console.WriteLine("   " + brand.BrandId + "          " + brand.BrandName);
            }
            Console.WriteLine("-------------------------------------");
        }

        private static void BrandgetAll()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            Console.WriteLine("---- BrandGetAll--");
            Console.WriteLine("BrandID  " + "  Brandname");

            foreach (var brand in brandManager.GetAll())
            {

                Console.WriteLine("   " + brand.BrandId + "          " + brand.BrandName);
            }
            Console.WriteLine("-------------------------------------");
        }

        private static void ColorGetById(int id)
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());
            Console.WriteLine("---- ColorGetById--");
            Console.WriteLine("ColorID  " + "  Colorname");

            foreach (var color in colorManager.GetById(id))
            {

                Console.WriteLine("   " + color.ColorId + "          " + color.ColorName);
            }
            Console.WriteLine("-------------------------------------");
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());
            Console.WriteLine("---- ColorGetAll--");
            Console.WriteLine("ColorID  " + "  Colorname");

            foreach (var color in colorManager.GetAll())
            {

                Console.WriteLine("   " + color.ColorId + "          " + color.ColorName);
            }
            Console.WriteLine("-------------------------------------");
        }

        private static void CarGetByID(int id)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("---- CarGetByID--");
            Console.WriteLine("Car ID  " + "  Car Marke" + "   Car Color " + " Car Price " + "   Car Description " + "     Car Model Year");

            foreach (var car in carManager.GetById(id))
            {

                Console.WriteLine("   " + car.CarId + "          " + car.BrandId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
            }
            Console.WriteLine("-------------------------------------");
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("----  CarGetAll--");
            List<Car> cars = carManager.GetAll();
            Console.WriteLine("Car ID  " + "  Car Marke" + "   Car Color " + " Car Price " + "   Car Description " + "     Car Model Year");
            foreach (var car in cars)
            {
                Console.WriteLine("   " + car.CarId + "          " + car.BrandId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            
            Console.WriteLine("-------------------------------------");
            

        }

        ////     CarManager carManager = new CarManager(new InMemoryCarDal());
        //     Console.WriteLine("----- Actual --- Car List --------------------");
        //     Console.WriteLine("Car ID  " + "  Car Marke" + "   Car Color " + " Car Price " + "   Car Description " + "     Car Model Year");
        //     foreach (var car in carManager.GetAll())
        //     {  
        //         Console.WriteLine("   " +car.CarId + "          " + car.BranId + "           "         + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //     }

        //     Console.WriteLine("----- Actual --- Car ID 3 --------------------");
        //     int id = 3;
        //     foreach (var car in carManager.GetByCarId(id))
        //     {
        //         Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //     }

        //     Console.WriteLine("----- Update --- Car ID 3 --------------------");
        //     carManager.Update(new Car { CarId = id, BranId = 3, ColorId = 3, DailyPrice = 12000, ModelYear = 2000, Description = "7 Sitzer" });
        //     Console.WriteLine(" CarId = id, BranId = 3, ColorId = 3, DailyPrice = 12000, ModelYear = 2000, Description = 7 Sitzer");
        //     Console.WriteLine("----- After Update --- Car List --------------------");
        //     foreach (var car in carManager.GetAll())
        //     {  
        //         Console.WriteLine("   " +car.CarId + "          " + car.BranId + "           "         + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //     }
        //     Console.WriteLine("----- Add --- New Car --------------------");
        //     carManager.Add(new Car { CarId = 5, BranId = 2, ColorId = 1, DailyPrice = 19900, ModelYear = 2015, Description = "3 Sitzer" });
        //     Console.WriteLine("CarId = 5, BranId = 2, ColorId = 1, DailyPrice = 19900, ModelYear = 2015, Description = 3 Sitzer");
        //     Console.WriteLine("----- After Add --- Car List --------------------");
        //     foreach (var car in carManager.GetAll())
        //     {
        //         Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //     }
        //     id = 4;
        //     Console.WriteLine("----- Delete --- Car --------------------");
        //     carManager.Delete(new Car { CarId = id });
        //     Console.WriteLine(" Delete CarId 4 ");
        //     Console.WriteLine("----- After Delete --- Car List --------------------");
        //     foreach (var car in carManager.GetAll())
        //     {
        //         Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //     }



    }
}

