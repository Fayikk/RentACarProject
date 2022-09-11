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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
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

        public void Delete(Brand entity)
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

        public Brand Get(Expression<Func<Brand, bool>> Filter)
        {
            using (RentCarsContext context = new RentCarsContext())
            {
                //Filtre olması gerektiği için herhangi bir şekilde sorgulama işlemi gerçekleştirilmedi.
                return context.Set<Brand>().SingleOrDefault(Filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> Filter = null)
        {
            //Burada filtre olma yada olmam durumıun geçerli olduğu için bnların kontrolünün sağlanması gerekmektedir.

            using (RentCarsContext context = new RentCarsContext())
            {
                return Filter == null ?
                    context.Set<Brand>().ToList() :
                    context.Set<Brand>().Where(Filter).ToList();
            }
        }

        public void Update(Brand entity)
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
