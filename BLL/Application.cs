using Abstractions;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Application<T> : ICrud<T>
    {


        private DbApplication<T> db = new DbApplication<T>();
        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void DeleteAsync(int id)
        {
            db.DeleteAsync(id);
        }

        public IList<T> GetAll()
        {
            return db.GetAll();
        }

        public Task<IList<T>> GetAllAsync()
        {
            return db.GetAllAsync();
        }

        public T GetById(int id)
        {
            return db.GetById(id);
        }

        public Task<T> GetByIdAsync(int id)
        {
            return GetByIdAsync(id);
        }

        public T Save(T entity)
        {
            return db.Save(entity);
        }

        public Task<T> SaveAsync(T entity)
        {
            return db.SaveAsync(entity);
        }
    }
}
