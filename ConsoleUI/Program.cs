using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        public static void Rakam(out int section)
        {
            string input = "";
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            section = 0;
            do
            {

                Console.Write("Seciminizi Giriniz  : ");
                input = Console.ReadLine();
                if (!input.ToUpper().Equals("Q"))
                {

                    int x = 0;
                    bool result = int.TryParse(input, out x);
                    if (result)
                    {
                        Console.WriteLine(x);
                        if (x > 0 && x <= 98)
                        {
                            section = x;
                            count1++;
                            Console.WriteLine("Rakam " + section + " Girildi");
                            // buraya case ekle
                            break;
                        }
                        else if (x < 0 || x >= 99)
                        {
                            Console.WriteLine("Secenekte olmaya Rakam" + section + " Girildi");
                            count3++;
                            continue;
                        }
                        //else if (section <= 0 || se<)
                        //{
                        //    Console.WriteLine("Cikis girildi");
                        //    break;
                        //}

                    }
                    else
                        count2++;
                    Console.WriteLine("hata olustu, tekrar deneyiniz  ");

                    continue;


                }
                else
                    Console.WriteLine("Cikis secildi ");
                count2++;


            }
            while (!input.ToUpper().Equals("Q"));

        }
        private static void AnaMenu()
        {
            Console.WriteLine("--- ANA MENÜ ---");
            Console.WriteLine();
            Console.WriteLine("--- ARAC BÖLÜMÜ --- ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("11) Filo Listesi");
            Console.WriteLine("12) Araba Detayi");
            Console.WriteLine("13) Filoya Arac ekleme EKSIK");
            Console.WriteLine("14) Arac bilgileri Düzeltme ");
            Console.WriteLine("15) Filoya Arac cikartma EKSIK");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine();
            Console.WriteLine("--- MÜSTERI BÖLÜMÜ --- ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("21) Musteri Ekleme EKSIS");
            Console.WriteLine("22) Musteri Düzeltme EKSIS");
            Console.WriteLine("23) Musteri Silme EKSIS");
            Console.WriteLine("31) Kullanici Ekleme EKSIS");
            Console.WriteLine("32) Kullanici Düzeltme EKSIS");
            Console.WriteLine("33) Kullanici Silme EKSIS");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine();
            Console.WriteLine("--- KIRALAMA BÖLÜMÜ --- ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("44) Arac Kiralama ");
            Console.WriteLine("45) Arac Kiralama Düzeltme");
            Console.WriteLine("46) Arac Kiralama iptal");
            Console.WriteLine();
            Console.WriteLine("47) Arac Iade ");
            Console.WriteLine("48) Arac Iade Düzeltme");
            Console.WriteLine("49) Arac Iade iptal");
            Console.WriteLine();
            Console.WriteLine("51) Kiradaki Araclar");
            Console.WriteLine("55) kiralananbilir Araclar");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine();
            Console.WriteLine("--- EDIT BÖLÜMÜ --- ");
            Console.WriteLine("81) renk Ekleme EKSIS");
            Console.WriteLine("82) renk Düzeltme EKSIS");
            Console.WriteLine("83) renk Silme EKSIS");

            Console.WriteLine("91) Marka Ekleme EKSIS");
            Console.WriteLine("92) Marka Düzeltme EKSIS");
            Console.WriteLine("93) Marka Silme EKSIS");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Q) Cikis");
            Console.WriteLine("-----------------------");
        }
        public static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EFCarDal());
            //var result = carManager.GetCarDetails();
            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(
            //                         "       " + car.CarId
            //                        + "       " + car.BrandName
            //                        + "       " + car.CarModel
            //                        //+ "       " + car.ColorName
            //                        //+ "       " + car.Description
            //                        //+ "       " + car.ModelYear
            //                        //+ "       " + car.DailyPrice

            //                        );
            //    }
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //Console.WriteLine("----- Delete --- Car --------------------");
            //var input = int.Parse(Console.ReadLine());
            //carManager.Delete(new Car { CarId = input });
            //Console.WriteLine(" Delete CarId " + input );

            //Console.WriteLine("----  Filo Listesi--");

            //var result2 = carManager.GetCarDetails();
            //if (result2.Success == true)
            //{
            //    foreach (var car in result2.Data)
            //    {
            //        Console.WriteLine(
            //                         "       " + car.CarId
            //                        + "       " + car.BrandName
            //                        + "       " + car.CarModel
            //                        //+ "       " + car.ColorName
            //                        //+ "       " + car.Description
            //                        //+ "       " + car.ModelYear
            //                        //+ "       " + car.DailyPrice

            //                        );
            //    }
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}















            //int section = 0;
            //AnaMenu();
            //Rakam(out section);
            //bool exit = true;
            //Console.WriteLine("Secilen Bölüm   : " + section);


            //// while loop dene!!!!

            //do
            //{

            //    int mainMenuInput = section;

            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();

            //    switch (mainMenuInput)
            //    {
            //        case 11:
            //            FiloListesi();
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            break;
            //        case 12:
            //            FiloListesi();
            //            Console.Write("lütfen Detayli gösterilecek Araci seciniz : ");
            //            var option = int.Parse(Console.ReadLine());
            //            ArabaDetayi(option);
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            break;
            //        case 13:
            //            FiloListesi();
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            AracEkleme();
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            FiloListesi();
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            break;
            //        case 14:
            //            FiloListesi();
            //            Console.Write("lütfen Araci seciniz : ");
            //            var option1 = int.Parse(Console.ReadLine());
            //            ArabaDetayi(option1);
            //            var optionAracUpdate = option1 ;
            //            AracYenile(optionAracUpdate);
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            ArabaDetayi(option1);
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            break;
            //        case 15:
            //            FiloListesi();
            //            Console.Write("lütfen Araci seciniz : ");
            //            var optionAracDelete = int.Parse(Console.ReadLine());
            //            AracCikarma(optionAracDelete);
            //            break;

            //        case 2:

            //            break;
            //        case 3:

            //            break;

            //        default:

            //            break;
            //    }
            //    exit = false;
            //}

            //while (exit);


        }
        private static void FiloListesi()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("----  Filo Listesi--");

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(
                                     "       " + car.CarId
                                    + "       " + car.BrandName
                                    + "       " + car.CarModel
                                    //+ "       " + car.ColorName
                                    //+ "       " + car.Description
                                    //+ "       " + car.ModelYear
                                    //+ "       " + car.DailyPrice

                                    );
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
        private static void AracEkleme()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine(" ---  Filoya Arac ekleme --- ");

            Console.Write(" modelName : ");
            var optionAracModel = Console.ReadLine();
            Console.Write(" BrandID : ");
            var inputBrandID = int.Parse(Console.ReadLine());
            Console.Write(" Color ID : ");
            var optionAracColorId = int.Parse(Console.ReadLine());
            Console.Write(" ModelYear : ");
            var optionAracModelYear = int.Parse(Console.ReadLine());
            Console.Write(" price : ");
            var optionAracDailyPrice = int.Parse(Console.ReadLine());
            Console.Write(" Description : ");
            var optionAracDescription = Console.ReadLine();

            carManager.Add(new Car
            {
                BrandId = inputBrandID,
                CarModel = optionAracModel,
                ColorId = optionAracColorId,
                DailyPrice = optionAracDailyPrice,
                Description = optionAracDescription,
                ModelYear = optionAracModelYear
            });
            Console.WriteLine("-------------------------------------");
        }
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
        private static void AracCikarma(int optionAracDelete)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("----  Araci Filodan Cikar --");
            carManager.Delete(new Car { CarId = optionAracDelete });
            Console.WriteLine(optionAracDelete + "Araci Filodan Cikar");
            Console.WriteLine("-------------------------------------");
        }
        private static void AracYenile(int optionAracUpdate)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.Write(" modelName : ");
            var optionAracModel = Console.ReadLine();
            Console.Write(" BrandID : ");
            var inputBrandID = int.Parse(Console.ReadLine());
            Console.Write(" Color ID : ");
            var optionAracColorId = int.Parse(Console.ReadLine());
            Console.Write(" ModelYear : ");
            var optionAracModelYear = int.Parse(Console.ReadLine());
            Console.Write(" price : ");
            var optionAracDailyPrice = int.Parse(Console.ReadLine());
            Console.Write(" Description : ");
            var optionAracDescription = Console.ReadLine();

            carManager.Update(new Car
            {
                CarId = optionAracUpdate,
                BrandId = inputBrandID,
                CarModel = optionAracModel,
                ColorId = optionAracColorId,
                DailyPrice = optionAracDailyPrice,
                Description = optionAracDescription,
                ModelYear = optionAracModelYear
            });



        }

        //private static void RentalList()
        //{
        //    RentalManager rentalManager = new RentalManager(new EFRentalDal());
        //    RentCarList();
        //    Console.Write("Lütfen arabayi Seciniz :  ");
        //    var SelectedCarId = Convert.ToInt32(Console.ReadLine());
        //    Customerlist();
        //    Console.Write("Lütfen Sirketi Seciniz :  ");
        //    var SelectedCustomerId = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Lütfen Kiralama Tarihini giriniz  :  ");
        //    DateTime SelectedrentDate;
        //    SelectedrentDate = DateTime.Parse(Console.ReadLine());

        /* case 1:
                         bool exitAracFilosu = true;
                         //do
                         //{
                         //    Rakam(out section);
                         //    int AracFilosuInput = section;
                         //    Console.WriteLine();
                         //    Console.WriteLine("Arac filosu Input alinan " + AracFilosuInput);
                         //    Console.WriteLine();
                         //    Console.WriteLine();
                         //    Console.WriteLine();
                         //    Console.WriteLine();
                         //    Console.WriteLine();
                         //    switch (AracFilosuInput)
                         //    {

                         //        case 19:
                         //            exitAracFilosu = false;
                         //            break;
                         //        default:
                         //            Console.WriteLine("gecersiz giris");
                         //            break;

                         //    }
                         //}
                         //while (!exitAracFilosu);

                         break;
        */

        //    rentalManager.Add(new Rental { CarId = SelectedCarId, CustomerId = SelectedCustomerId, RentDate = SelectedrentDate });

        //    CarManager carManager = new CarManager(new EFCarDal());
        //    var resultresultRentCar = carManager.GetCarRentList();

        //    foreach (var rent in resultresultRentCar.Data)
        //    {
        //        Console.WriteLine(rent.RentalId + "  " + rent.CarId + "  " + rent.BrandName + "  " + rent.CarModel + "  " + rent.CarColor + "  " + rent.CompanyName + "  " + rent.UserFirstName + "  " + rent.UserLastName + "  " + rent.RentDate.ToString() + "  " + rent.ReturnDate.ToString());
        //    }
        //}

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

        //private static void ColorGetById(int id)
        //{
        //    ColorManager colorManager = new ColorManager(new EFColorDal());
        //    Console.WriteLine("---- ColorGetById--");
        //    Console.WriteLine("ColorID  " + "  Colorname");

        //    foreach (var color in colorManager.GetById(id))
        //    {

        //        Console.WriteLine("   " + color.ColorId + "          " + color.ColorName);
        //    }
        //    Console.WriteLine("-------------------------------------");
        //}

        //private static void ColorGetAll()
        //{
        //    ColorManager colorManager = new ColorManager(new EFColorDal());
        //    Console.WriteLine("---- ColorGetAll--");
        //    Console.WriteLine("ColorID  " + "  Colorname");

        //    foreach (var color in colorManager.GetAll())
        //    {

        //        Console.WriteLine("   " + color.ColorId + "          " + color.ColorName);
        //    }
        //    Console.WriteLine("-------------------------------------");
        //}





        //------------------------------------------------------------ESKI 
        //private static void InMemoryCarActual()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());
        //    Console.WriteLine("----- Actual --- Car List --------------------");
        //    Console.WriteLine("Car ID  " + "  Car Marke" + "   Car Color " + " Car Price " + "   Car Description " + "     Car Model Year");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //    }
        //}

        //private static void InMemoryCarID()
        //{
        // Console.WriteLine("----- Actual --- Car ID 3 --------------------");
        //             int id = 3;
        //             foreach (var car in carManager.GetByCarId(id))
        //             {
        //                 Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //             }
        //}

        //private static void updateCar()
        //{
        //    Console.WriteLine("----- Update --- Car ID 3 --------------------");
        //    carManager.Update(new Car { CarId = id, BranId = 3, ColorId = 3, DailyPrice = 12000, ModelYear = 2000, Description = "7 Sitzer" });
        //    Console.WriteLine(" CarId = id, BranId = 3, ColorId = 3, DailyPrice = 12000, ModelYear = 2000, Description = 7 Sitzer");
        //    Console.WriteLine("----- After Update --- Car List --------------------");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //    }
        //}

        //private static void AddNewCar()
        //{
        //    Console.WriteLine("----- Add --- New Car --------------------");
        //    carManager.Add(new Car { CarId = 5, BranId = 2, ColorId = 1, DailyPrice = 19900, ModelYear = 2015, Description = "3 Sitzer" });
        //    Console.WriteLine("CarId = 5, BranId = 2, ColorId = 1, DailyPrice = 19900, ModelYear = 2015, Description = 3 Sitzer");
        //    Console.WriteLine("----- After Add --- Car List --------------------");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //    }
        //    id = 4;
        //}

        //private static void DeleteCar()
        //{
        //    Console.WriteLine("----- Delete --- Car --------------------");
        //    carManager.Delete(new Car { CarId = id });
        //    Console.WriteLine(" Delete CarId 4 ");
        //    Console.WriteLine("----- After Delete --- Car List --------------------");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("   " + car.CarId + "          " + car.BranId + "           " + car.ColorId + "        " + car.DailyPrice + "        " + car.Description + "               " + car.ModelYear);
        //    }
        //}




    }
}



