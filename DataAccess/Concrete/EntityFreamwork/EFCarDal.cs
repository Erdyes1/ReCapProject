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
    public class EFCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, Abstract.ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from a in context.Cars
                             join b in context.Colors
                             on a.CarId equals b.ColorId
                             join c in context.Brands
                             on a.BrandId equals c.BrandId
                             select new CarDetailDto
                             {
                                 CarId =a.CarId, 
                                 BrandName = c.BrandName, 
                                 ColorName =b.ColorName,
                                 CarModel = a.CarModel,
                                 DailyPrice= a.DailyPrice, 
                                 Description=a.Description, 
                                 ModelYear = a.ModelYear 
                             };
                return result.ToList();
                    }

           




        }
    }
}
