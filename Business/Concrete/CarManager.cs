﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult Add(Car car)
        {
            if (car.CarModel.Length < 2)
            {
                return new ErrorResult(Messages.CarNameWrong);
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }

        public IResult Delete(Car car)
        {   
            Console.WriteLine(Messages.QuestioncarDeleted);
            var Input = Console.ReadLine();
                _carDal.Delete(car);
            if (Input== "EVET")
            {
                
                return new SuccessResult(Messages.CarDeleted);
            }
            else
            {
                return new ErrorResult(Messages.CarNotDeleted);
            }
            
        }

        public IResult Update(Car car)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<List<Car>> GetById(int carId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.CarId == carId));
        }

        public IDataResult<List<Car>> GetAll()
        {
            if(DateTime.Now.Hour == 02)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
         
        }

       

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
                        return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarListed);
        }
    }
}
