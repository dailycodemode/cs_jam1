using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jam1.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll(); // array of any class; returning all from dB

        T FindById(int id); //  T   some class

        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
