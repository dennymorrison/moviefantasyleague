using System;
using System.Collections.Generic;

namespace MFL.Data.Repository.Contract
{
    public interface IRepository<T> where T: class
    {
        bool Delete(T entity);

        bool Create(T entity);

        int SaveChanges();

        IList<T> List(int skip, int take);

        T GetById(Guid id);
    }
}
