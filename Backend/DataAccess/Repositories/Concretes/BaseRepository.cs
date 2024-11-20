using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concretes
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        MyContext _db;

        public BaseRepository(MyContext db)
        {
            _db = db;
        }

        public void Add(T entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            _db.Remove(entity);
            _db.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetAllWithFilter(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().Where(expression).ToList();
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }
    }
}
