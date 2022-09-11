using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> Filter=null);
        T Get(Expression<Func<T, bool>> Filter);
        void Add(T entity);
        void Update(T entity);  
        void Delete(T entity);

    }
}
