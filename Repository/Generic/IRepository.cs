using AulaUdemy.Model;
using AulaUdemy.Model.Base;
using System.Collections.Generic;

namespace AulaUdemy.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exist(long id);
    }
}
