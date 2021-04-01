using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EFBrandDal : EfEntityRepositoryBase<Brand, ReCapProjectContext>, IBrandDal

    {

    }
}
