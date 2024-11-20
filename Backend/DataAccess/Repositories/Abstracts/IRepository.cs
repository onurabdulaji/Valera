using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface IRepository<T> where T : class
    {
        // Basic Commands
        // Basic Commands
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        List<T> GetAll();
        List<T> GetAllWithFilter(Expression<Func<T, bool>> expression);

    }
}
