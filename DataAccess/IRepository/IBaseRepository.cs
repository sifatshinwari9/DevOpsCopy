using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        List<T> GetByQuery(Delegate @delegate);
        void Add(T entity);
    }
}
