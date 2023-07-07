using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(List<TEntity> entityToDelete);
        void Delete(TEntity entityToDelete);

        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        TEntity GetByID(object id);
        //IEnumerable<TEntity> GetWithRawSql(string query,
        //    params object[] parameters);
        void Insert(TEntity entity);
        void Insert(List<TEntity> entity);

        void Update(TEntity entityToUpdate);

    }
}
