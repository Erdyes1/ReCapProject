using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            do
            {
                Console.WriteLine("--- ANA MENÜ ---");
                Console.WriteLine("1) Araç filosu ");
                Console.WriteLine("2) Musteriler EKSIK");
                Console.WriteLine("3) Kiralama EKSIK");
                Console.WriteLine("99) Cikis");
                Console.WriteLine("---------------------------");
                Console.Write("Lütfen seçiminizi giriniz   :  ");
                
                int mainMenuInput = int.Parse(Console.ReadLine());
                int[] mainMenuList = { 1, 2, 3 };
                int posMainMenu = Array.IndexOf(mainMenuList, mainMenuInput);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                if (posMainMenu < 0 | mainMenuInput / mainMenuInput != 1)
                {
                    mainMenuInput = 0;
                    Console.WriteLine("Dogru Secim Yapiniz");
                }
                else
                {
                    switch (mainMenuInput)
                    {
                        case 1:
                            bool exitAracFilosu = true;
                            do
                            {
                                Console.WriteLine("--- ARAC FILOSU ---");
                                Console.WriteLine("11) Filo Listesi");
                                Console.WriteLine("12) Araba Detayi");
                                Console.WriteLine("13) Filoya Arac ekleme EKSIK");
                                Console.WriteLine("14) Arac bilgileri Düzeltme EKSIK");
                                Console.WriteLine("15) Filodan Arac cikartma EKSIS");
                                Console.WriteLine("19) Ana Menü");
                                Console.Write("Lütfen seçiminizi giriniz   :  ");

                                int AracFilosuInput = int.Parse(Console.ReadLine());
                                int[] AracFilosuList = { 11, 12, 13, 14, 15 };
                                int posAracFilosu = Array.IndexOf(mainMenuList, mainMenuInput);
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                if (posAracFilosu < 0)
                                {
                                    AracFilosuInput = 0;
                                    Console.WriteLine("Dogru Secim Yapiniz");
                                }
                                else
                                {
                                    switch (AracFilosuInput)
                                    {
                                        case 11:
                                            FiloListesi();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();

                                            goto case 19;

                                        case 12:
                                            FiloListesi();
                                            Console.Write("lütfen Araci seciniz : ");
                                            int option = int.Parse(Console.ReadLine());
                                            ArabaDetayi(option);
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            continue;
                                        case 13:
                                            //CarAdd();

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            FiloListesi();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;
                                        case 14:
                                            //CarUpdate();
                                            break;
                                        case 15:
                                            //CarGetAll();
                                            option = int.Parse(Console.ReadLine());
                                            //CarDelete(option);
                                            break;
                                        case 19:
                                            exitAracFilosu = false;
                                            break;
                                    }
                                }
                            } while (exitAracFilosu);
                            break;
                        case 2:
                            Console.WriteLine("Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("Wednesday");
                            break;
                        case 99:
                            exit = false;
                            break;
                    }
                }
            }
            while (exit);
        }
        private static void FiloListesi()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("----  Filo Listesi--");
            //var result = carManager.GetAll();
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(
                                     "       " + car.CarId
                                    + "       " + car.BrandName
                                    + "       " + car.CarModel
                                    + "       " + car.ColorName
                                    + "       " + car.Description
                                    + "       " + car.ModelYear
                                    + "       " + car.DailyPrice);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ArabaDetayi(int option)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("----  Filo Listesi--");
            //var result = carManager.GetAll();
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    if (car.CarId == option)
                    {
                        Console.WriteLine(
                                                             "       " + car.CarId
                                                            + "       " + car.BrandName
                                                            + "       " + car.CarModel
                                                            + "       " + car.ColorName
                                                            + "       " + car.Description
                                                            + "       " + car.ModelYear
                                                            + "       " + car.DailyPrice);
                    }

                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }



        //private static void CarAdd()
        //{
        //    CarManager carManager = new CarManager(new EFCarDal());
        //    Console.WriteLine(" ---  Filoya Arac ekleme --- ");
        //    carManager.Add(new Car { CarId = 4, BrandId = 2, ColorId = 2, DailyPrice = 999999, Description = "3 Sitzer", ModelYear = 2015 });
        //    Console.WriteLine("CarId 4 -- BrandId 2 -- ColorId2 -- DailyPrice 999999 -- Description 3 Sitzer -- ModelYear = 2015");
        //    Console.WriteLine("-------------------------------------");
        //}
        private static void CarGetDetail()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("----  CarGetDetail--");

            var result = carManager.GetCarDetails();


            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarModel + "      " + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }



            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("-------------------------------------");
        }


        //  private static void CarDelete(int id)
        //  {
        //      CarManager carManager = new CarManager(new EFCarDal());
        //      Console.WriteLine("----  CarDelete--");
        //      carManager.Delete(new Car { CarId = id });
        //      Console.WriteLine("CarId 4 -- Delete");
        //      Console.WriteLine("-------------------------------------");
        //  }
        //  private static void CarUpdate()
        //  {
        //      CarManager carManager = new CarManager(new EFCarDal());
        //      Console.WriteLine("----  CarUpdate--");
        //      carManager.Update(new Car { CarId = 4, BrandId = 2, ColorId = 2, DailyPrice = 1500, Description = "3 Sitzer", ModelYear = 2015 });
        //      Console.WriteLine("CarId 4 -- new DailyPrice 1500");
        //      Console.WriteLine("-------------------------------------");
        //  }



        //private static void RentalList()
        //  {
        //      RentalManager rentalManager = new RentalManager(new EFRentalDal());
        //      //   RentCarList();
        //      Console.Write("Lütfen arabayi Seciniz :  ");
        //      var SelectedCarId = Convert.ToInt32(Console.ReadLine());
        //      //   Customerlist();
        //      Console.Write("Lütfen Sirketi Seciniz :  ");
        //      var SelectedCustomerId = Convert.ToInt32(Console.ReadLine());
        //      Console.Write("Lütfen Kiralama Tarihini giriniz  :  ");
        //      DateTime SelectedrentDate;
        //      SelectedrentDate = DateTime.Parse(Console.ReadLine());



        //      rentalManager.Add(new Rental { CarId = SelectedCarId, CustomerId = SelectedCustomerId, RentDate = SelectedrentDate });

        //      CarManager carManager = new CarManager(new EFCarDal());
        //      var resultresultRentCar = carManager.GetCarRentList();

        //      foreach (var rent in resultresultRentCar.Data)
        //      {
        //          Console.WriteLine(rent.RentalId + "  " + rent.CarId + "  " + rent.BrandName + "  " + rent.CarModel + "  " + rent.CarColor + "  " + rent.CompanyName + "  " + rent.UserFirstName + "  " + rent.UserLastName + "  " + rent.RentDate.ToString() + "  " + rent.ReturnDate.ToString());
        //      }
        //  }




        //private static void BrandGetById(int id)
        //{
        //    BrandManager brandManager = new BrandManager(new EFBrandDal());
        //    Console.WriteLine("---- BrandGetById--");
        //    Console.WriteLine("BrandID  " + "  Brandname");

        //    foreach (var brand in brandManager.GetById(id))
        //    {

        //        Console.WriteLine("   " + brand.BrandId + "          " + brand.BrandName);
        //    }
        //    Console.WriteLine("-------------------------------------");
        //}



        //private static void RentCarList()
        //{
        //    CarManager carManager = new CarManager(new EFCarDal());
        //    Console.WriteLine("----  Kiralanabilecek Araclar --");

        //    var result = carManager.GetCarRentList();


        //    if (result.Success == true)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.CarId + "    " + car.CarModel + "      " + car.BrandName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }

        //}

        //private static void Customerlist()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
        //    Console.WriteLine("----  Sirketi Seciniz--");

        //    foreach (var user in customerManager.GetAll().Data)
        //    {
        //        Console.WriteLine(user.CustomerId + "    " + user.UserId + "   " + user.CompanyName);
        //    }

        //    Console.WriteLine(" ");
        //    Console.WriteLine(" ");

        //    Console.WriteLine("-------------------------------------");

        //}






        //    //

        //    //private static void BrandgetAll()
        //    //{
        //    //    BrandManager brandManager = new BrandManager(new EFBrandDal());
        //    //    Console.WriteLine("---- BrandGetAll--");
        //    //    Console.WriteLine("BrandID  " + "  Brandname");

        //    //    foreach (var brand in brandManager.GetAll())
        //    //    {

        //    //        Console.WriteLine("   " + brand.BrandId + "          " + brand.BrandName);
        //    //    }
        //    //    Console.WriteLine("-------------------------------------");
        //    //}

        //    //private static void ColorGetById(int id)
        //    //{
        //    //    ColorManager colorManager = new ColorManager(new EFColorDal());
        //    //    Console.WriteLine("---- ColorGetById--");
        //    //    Console.WriteLine("ColorID  " + "  Colorname");

        //    //    foreach (var color in colorManager.GetById(id))
        //    //    {

        //    //        Console.WriteLine("   " + color.ColorId + "          " + color.ColorName);
        //    //    }
        //    //    Console.WriteLine("-------------------------------------");
        //    //}

        //    //private static void ColorGetAll()
        //    //{
        //    //    ColorManager colorManager = new ColorManager(new EFColorDal());
        //    //    Console.WriteLine("---- ColorGetAll--");
        //    //    Console.WriteLine("ColorID  " + "  Colorname");

        //    //    foreach (var color in colorManager.GetAll())
        //    //    {

        //    //        Console.WriteLine("   " + color.ColorId + "          " + color.ColorName);
        //    //    }
        //    //    Console.WriteLine("-------------------------------------");
        //    //}

        //    //




        //    ////     CarManager carManager = new CarManager(new InMemoryCarDal());
        //    //     Console.WriteLine("----- Actual --- Car List --------------------");
        //    //     Console.WriteLine("Car ID  " + "  Car Marke" + "   Car Color " + " Car Price " + "   Car Description " + "     Car Model Year");
        //    //     foreach (var car in carManager.GetAll())
        //    //     {  
        //    //         Console.WriteLine("   " +car.CarId + "          " + car.BranId + "           "         + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //    //     }

        //    //     Console.WriteLine("----- Actual --- Car ID 3 --------------------");
        //    //     int id = 3;
        //    //     foreach (var car in carManager.GetByCarId(id))
        //    //     {
        //    //         Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //    //     }

        //    //     Console.WriteLine("----- Update --- Car ID 3 --------------------");
        //    //     carManager.Update(new Car { CarId = id, BranId = 3, ColorId = 3, DailyPrice = 12000, ModelYear = 2000, Description = "7 Sitzer" });
        //    //     Console.WriteLine(" CarId = id, BranId = 3, ColorId = 3, DailyPrice = 12000, ModelYear = 2000, Description = 7 Sitzer");
        //    //     Console.WriteLine("----- After Update --- Car List --------------------");
        //    //     foreach (var car in carManager.GetAll())
        //    //     {  
        //    //         Console.WriteLine("   " +car.CarId + "          " + car.BranId + "           "         + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //    //     }
        //    //     Console.WriteLine("----- Add --- New Car --------------------");
        //    //     carManager.Add(new Car { CarId = 5, BranId = 2, ColorId = 1, DailyPrice = 19900, ModelYear = 2015, Description = "3 Sitzer" });
        //    //     Console.WriteLine("CarId = 5, BranId = 2, ColorId = 1, DailyPrice = 19900, ModelYear = 2015, Description = 3 Sitzer");
        //    //     Console.WriteLine("----- After Add --- Car List --------------------");
        //    //     foreach (var car in carManager.GetAll())
        //    //     {
        //    //         Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //    //     }
        //    //     id = 4;
        //    //     Console.WriteLine("----- Delete --- Car --------------------");
        //    //     carManager.Delete(new Car { CarId = id });
        //    //     Console.WriteLine(" Delete CarId 4 ");
        //    //     Console.WriteLine("----- After Delete --- Car List --------------------");
        //    //     foreach (var car in carManager.GetAll())
        //    //     {
        //    //         Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //    //     }

        //}

    }
}



