using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RailwaySystem.Core.Repository
{
    public abstract class DataRepositoryBase<T, U> : IDataRepository<T>
        where T : class, IKeyEntity, new()
        where U : DbContext, new()
    {
        protected abstract DbSet<T> DbSet(U entityContext);
        protected abstract Expression<Func<T, bool>> IdentifierPredicate(U entityContext, int id);

        T AddEntity(U entityContext, T entity)
        {
            return this.DbSet(entityContext).Add(entity);
        }

        IEnumerable<T> GetEntities(U entityContext)
        {
            return this.DbSet(entityContext).ToFullyLoaded();
        }

        T GetEntity(U entityContext, int id)
        {
            return this.DbSet(entityContext).Where(this.IdentifierPredicate(entityContext, id)).FirstOrDefault();
        }
        
        T UpdateEntity(U entityContext, T entity)
        {
            var q = this.DbSet(entityContext).Where(this.IdentifierPredicate(entityContext, entity.EntityId));
            return q.FirstOrDefault();
        }

        public virtual T Add(T entity)
        {
            using (U entityContext = new U())
            {
                T addedEntity = this.AddEntity(entityContext, entity);
                entityContext.SaveChanges();
                return addedEntity;
            }
        }

        public virtual void Remove(T entity)
        {
            using (U entityContext = new U())
            {
                entityContext.Entry<T>(entity).State = EntityState.Deleted;
                entityContext.SaveChanges();
            }
        }

        public virtual void Remove(int id)
        {
            using (U entityContext = new U())
            {
                T entity = this.GetEntity(entityContext, id);
                entityContext.Entry<T>(entity).State = EntityState.Deleted;
                entityContext.SaveChanges();
            }
        }

        public virtual T Update(T entity)
        {
            using (U entityContext = new U())
            {
                T existingEntity = this.UpdateEntity(entityContext, entity);

                SimpleMapper.PropertyMap(entity, existingEntity);

                entityContext.SaveChanges();
                return existingEntity;
            }
        }

        public virtual IEnumerable<T> Get()
        {
            using (U entityContext = new U())
                return (this.GetEntities(entityContext)).ToArray().ToList();
        }

        public virtual T Get(int id)
        {
            using (U entityContext = new U())
                return this.GetEntity(entityContext, id);
        }
    }
}
