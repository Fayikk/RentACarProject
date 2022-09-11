using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (RentCarsContext context = new RentCarsContext())
            {
                //Referans ataama işlemi 
                var addedEntity = context.Entry(entity);
                //Durum belirtme işlemi
                addedEntity.State=Microsoft.EntityFrameworkCore.EntityState.Added;
                //Değişiklikleri kaydetma
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
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

        public Color Get(Expression<Func<Color, bool>> Filter)
        {
            using (RentCarsContext context = new RentCarsContext())
            {
                //Filtre olması gerektiği için herhangi bir şekilde sorgulama işlemi gerçekleştirilmedi.
                return context.Set<Color>().SingleOrDefault(Filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> Filter = null)
        {
            //Burada filtre olma yada olmam durumıun geçerli olduğu için bnların kontrolünün sağlanması gerekmektedir.

            using (RentCarsContext context = new RentCarsContext())
            {
                return Filter == null ?
                    context.Set<Color>().ToList():
                    context.Set<Color>().Where(Filter).ToList();
            }
        }

        public void Update(Color entity)
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
