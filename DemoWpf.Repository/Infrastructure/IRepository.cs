using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWpf.Repository.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        //dynamic Add(T entity);
        //void Add(IEnumerable<T> entities);
        //bool Update(T entity);
        //void Delete(T entity);
        //T GetById(object id);
        //IEnumerable<T> GetAll();
    }
}
