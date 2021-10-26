using Abstractions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DbApplication<T> : ICrud<T>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> SaveAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
