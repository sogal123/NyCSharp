using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repository
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Delete(string entity);
        void Update(int index, T entity);
        void SaveChanges();
        List<T> GetAll();

    }
}
