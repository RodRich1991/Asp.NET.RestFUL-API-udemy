using RestWithAsp.NET_core.UDEMY.v1.Model.Base;
using RestWithAsp.NET_core.UDEMY.V1.Model;
using System.Collections.Generic;

namespace RestWithAsp.NET_core.UDEMY.V1.Repository.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T Create(T entity);

        T FindById(long id);

        List<T> FindAll();

        T Update(T entity);

        void Delete(long id);

        bool Exist(long? id);
    }
}
