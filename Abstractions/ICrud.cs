using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface ICrudAsync<T>
    {
        Task<T> SaveAsync(T entity);
        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        void DeleteAsync(int id);
    }

    public interface ICrud<T> : ICrudAsync<T>
    {
        T Save(T entity);
        IList<T> GetAll();
        T GetById(int id);
        void Delete(int id);

    }
}
