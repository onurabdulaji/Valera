using Bussines.ManagerServices.Abstracts;
using DataAccess.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.ManagerServices.Concretes
{
    public class BaseManager<T> : IManager<T> where T : class
    {
        protected IRepository<T> _iRepository;

        public BaseManager(IRepository<T> iRepository)
        {
            _iRepository = iRepository;
        }

        public void TAdd(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null.");
            _iRepository.Add(entity);
        }

        public void TDelete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null.");
            _iRepository.Delete(entity);
        }

        public List<T> TGetAll()
        {
            return _iRepository.GetAll();
        }

        public List<T> TGetAll(Expression<Func<T, bool>> expression)
        {
            return _iRepository.GetAllWithFilter(expression);
        }

        public T TGetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID must be greater than 0.", nameof(id));
            return _iRepository.GetById(id);
        }

        public void TUpdate(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null.");
            _iRepository.Update(entity);
        }
    }
}
