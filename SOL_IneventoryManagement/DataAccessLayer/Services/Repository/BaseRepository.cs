using DataAccessLayer.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Repository
{
    class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal ApplicationDbContext context;
        internal DbSet<TEntity> dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();

        }

        //public virtual IEnumerable<TEntity> GetWithRawSql(string query,
        //    params object[] parameters)
        //{
        //    return dbSet.SqlQuery(query, parameters).ToList();
        //}

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            try
            {

            
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

       

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
            }
            catch(Exception ex)
            {
                throw new Exception();
            }


        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
            //context.Manufactures.Add(entity);
            context.SaveChanges();

        }


        public virtual void Insert(List<TEntity> entities)
        {
            
            foreach(var entity in entities) 
            { 
            dbSet.Add(entity);
            //context.Manufactures.Add(entity);
            context.SaveChanges();
            }

        }



        public virtual void Delete(List<TEntity> entityToDelete)
        {
            foreach(var deleteentity in entityToDelete) 
            { 
            if (context.Entry(deleteentity).State == EntityState.Detached)
            {
                dbSet.Attach(deleteentity);
            }
            dbSet.Remove(deleteentity);

            context.SaveChanges();
            }
        }



        public virtual void Delete(TEntity entityToDelete)
        {
           
                if (context.Entry(entityToDelete).State == EntityState.Detached)
                {
                    dbSet.Attach(entityToDelete);
                }
                dbSet.Remove(entityToDelete);

                context.SaveChanges();
        }


        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);

            context.Entry(entityToUpdate).State = EntityState.Modified;
            context.SaveChanges();

        }


    }
}
