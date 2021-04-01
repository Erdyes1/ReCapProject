using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EFRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
    }
}
