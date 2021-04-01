using Core.DataAccess;
using DataAccess.DTOs;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();

        List<CarRentListDto> GetCarRentLists();
    }
}
