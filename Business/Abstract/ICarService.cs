using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetById(int carId);
        IDataResult <List<Car>> GetAll();
        



        IDataResult<List<CarDetailDto>> GetCarDetails();
        
        IDataResult<List<CarRentListDto>> GetCarRentList();

    }
}
