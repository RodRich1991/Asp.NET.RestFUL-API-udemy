using RestWithAsp.NET_core.UDEMY.V1.Models;
using System.Collections.Generic;

namespace RestWithAsp.NET_core.UDEMY.V1.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person FindById(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);
    }
}
