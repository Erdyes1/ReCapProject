using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);

        List<Brand> GetById(int brandId);
        List<Brand> GetAll();
    }
}
