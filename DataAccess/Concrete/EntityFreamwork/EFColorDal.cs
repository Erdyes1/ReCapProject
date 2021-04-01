using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EFColorDal : EfEntityRepositoryBase<Color, ReCapProjectContext>, IColorDal
    {

    }
}
