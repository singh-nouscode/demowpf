using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWpf.Repository.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        private IDbConnection _dbContext;
        public RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected IDbConnection DataContext
        {
            get { return _dbContext ?? (_dbContext = DatabaseFactory.Get()); }
        }

        //public virtual dynamic Add(T entity)
        //{
        //    return DataContext.Insert<T>(entity);
        //}

        //public virtual void Add(IEnumerable<T> entities)
        //{
        //    DataContext.Insert(entities);
        //}

        //public virtual bool Update(T entity)
        //{
        //    return DataContext.Update(entity);
        //}

        //public virtual void Delete(T entity)
        //{
        //    DataContext.Delete(entity);
        //}

        //public virtual T GetById(object id)
        //{
        //    return DataContext.Get<T>(id);
        //}

        //public virtual IEnumerable<T> GetAll()
        //{
        //    return DataContext.GetAll<T>();
        //}
    }
}
