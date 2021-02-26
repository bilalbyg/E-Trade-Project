using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext : DbContext,new()
    {
        public void Add(TEntity entity)
        {   // IDisposable pattern implementation of C#
            using (TContext context = new TContext()) // For memory optimization("using" calls  garbage collector after working end)
            {
                var addedEntity = context.Entry(entity); // Reference pairing
                addedEntity.State = EntityState.Added; // Add operation to database
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) // For memory optimization("using" calls  garbage collector after working end)
            {
                var deletedEntity = context.Entry(entity); // Reference pairing
                deletedEntity.State = EntityState.Deleted; // Delete operation from database
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) // For memory optimization("using" calls  garbage collector after working end)
            {
                var updatedEntity = context.Entry(entity); // Reference pairing
                updatedEntity.State = EntityState.Modified; // Update operation of an entity from database
                context.SaveChanges();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }
    }
}
