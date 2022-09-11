using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentCarsContext context = new RentCarsContext())
            {
                //Referans ataama işlemi 
                var addedEntity = context.Entry(entity);
                //Durum belirtme işlemi
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                //Değişiklikleri kaydetma
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentCarsContext context = new RentCarsContext())
            {
                //Referans ataama işlemi 
                var deletedEntity = context.Entry(entity);
                //Durum belirtme işlemi
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                //Değişiklikleri kaydetma
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> Filter)
        {
            using (RentCarsContext context = new RentCarsContext())
            {
                //Filtre olması gerektiği için herhangi bir şekilde sorgulama işlemi gerçekleştirilmedi.
                return context.Set<Car>().SingleOrDefault(Filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> Filter = null)
        {
            //Burada filtre olma yada olmam durumıun geçerli olduğu için bnların kontrolünün sağlanması gerekmektedir.

            using (RentCarsContext context = new RentCarsContext())
            {
                return Filter == null ?
                    context.Set<Car>().ToList() :
                    context.Set<Car>().Where(Filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (RentCarsContext context = new RentCarsContext())
            {
                //Referans ataama işlemi 
                var updatedEntity = context.Entry(entity);
                //Durum belirtme işlemi
                updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                //Değişiklikleri kaydetma
                context.SaveChanges();
            }
        }
    }
}
