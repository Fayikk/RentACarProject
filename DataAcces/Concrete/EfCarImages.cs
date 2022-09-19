using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete
{
    public class EfCarImages : EfEntityRepositoryBase<CarImages, RentCarsContext>, ICarImagesDal
    {
    }
}
