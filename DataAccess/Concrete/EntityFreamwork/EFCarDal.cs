using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EFCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from a in context.Cars
                             join b in context.Colors
                             on a.ColorId equals b.ColorId
                             join c in context.Brands
                             on a.BrandId equals c.BrandId
                             select new CarDetailDto
                             {
                                 CarId = a.CarId,
                                 BrandName = c.BrandName,
                                 ColorName = b.ColorName,
                                 CarModel = a.CarModel,
                                 DailyPrice = a.DailyPrice,
                                 Description = a.Description,
                                 ModelYear = a.ModelYear
                             };
                return result.ToList();
            }
        }

        public List<CarRentListDto> GetCarRentLists()
        {
            using (ReCapProjectContext context1 = new ReCapProjectContext())
            {
                var resultRentCar = from a in context1.Rentals
                                    join b in context1.Customers
                                    on a.CustomerId equals b.CustomerId
                                    join c in context1.Users
                                    on b.UserId equals c.UserId
                                    join d in context1.Cars
                                    on a.CarId equals d.CarId
                                    join e in context1.Brands
                                    on d.BrandId equals e.BrandId
                                    join f in context1.Colors
                                    on d.ColorId equals f.ColorId
                                    select new CarRentListDto
                                    {
                                        RentalId = a.RentalId,
                                        CarId = d.CarId,
                                        BrandName = e.BrandName,
                                        CarModel = d.CarModel,
                                        CarColor = f.ColorName,
                                        CompanyName = b.CompanyName,
                                        UserFirstName = c.UserFirstName,
                                        UserLastName = c.UserLastName,
                                        RentDate = a.RentDate,
                                        ReturnDate = a.ReturnDate
                                    };
                return resultRentCar.ToList();
            }
        }
    }
}
