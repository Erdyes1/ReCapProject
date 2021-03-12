using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);

        IDataResult<List<Brand>> GetById(int brandId);
        IDataResult<List<Brand>> GetAll();
    }
}
