﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> Get()
        {
            return _brandDal.Get();
        }

        public List<Brand> GetAll(int Id)
        {
            return _brandDal.GetAll();
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
