using RestWithAsp.NET_core.UDEMY.V1.Model;
using System.Collections.Generic;

namespace RestWithAsp.NET_core.UDEMY.V1.Repository
{
    public interface IBaseRepository
    {
        Person Create(Person person);

        Person FindById(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);

        bool Exist(long? id);
    }
}
