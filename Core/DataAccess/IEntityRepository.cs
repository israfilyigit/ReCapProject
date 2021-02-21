using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> Filter = null); // Tüm  datayı istenilirse filitre uygulayarak almak
        T Get(Expression<Func<T, bool>> Filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);


    }
}
