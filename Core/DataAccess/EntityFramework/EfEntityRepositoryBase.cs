using DataAcces.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        //Şimdi burada koşul eklemesi gerçekleştirelim.
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                //Referans ataama işlemi 
                var addedEntity = context.Entry(entity);
                //Durum belirtme işlemi
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                //Değişiklikleri kaydetma
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                //Referans ataama işlemi 
                var deletedEntity = context.Entry(entity);
                //Durum belirtme işlemi
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                //Değişiklikleri kaydetma
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> Filter)
        {
            using (TContext context = new TContext())
            {
                //Filtre olması gerektiği için herhangi bir şekilde sorgulama işlemi gerçekleştirilmedi.
                return context.Set<TEntity>().SingleOrDefault(Filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> Filter = null)
        {
            //Burada filtre olma yada olmam durumıun geçerli olduğu için bnların kontrolünün sağlanması gerekmektedir.

            using (TContext context = new TContext())
            {
                return Filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(Filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
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
