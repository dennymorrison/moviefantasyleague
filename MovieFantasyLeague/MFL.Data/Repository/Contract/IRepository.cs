using System;
using System.Collections.Generic;

namespace MFL.Data.Repository.Contract
{
    public interface IRepository<T> where T: class
    {
        bool Delete(Guid id);

        bool Create(T entity);

        IList<T> List(int skip, int take);

        T GetById(Guid id);

        bool Update(T entity);
    }
}
