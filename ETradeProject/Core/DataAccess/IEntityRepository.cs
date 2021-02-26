using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Generic Repository Desing Pattern
    public interface IEntityRepository<T> where T : class,IEntity,new() // Generic constraint (reference type,IEntity implementation,newable
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); // Get list of all choosen entity from database with or without a filter
        T Get(Expression<Func<T, bool>> filter); // Get choosen entity from database with a filter
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
