using RestWithAsp.NET_core.UDEMY.V1.Model;
using RestWithAsp.NET_core.UDEMY.V1.Repository;
using System.Collections.Generic;

namespace RestWithAsp.NET_core.UDEMY.V1.Service.Implementation
{
    public class PersonServiceImpl : IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonServiceImpl(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Create(Person person)
        {
            return _personRepository.Create(person);
        }

        public void Delete(long id)
        {
            _personRepository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _personRepository.FindAll();
        }

        public Person FindById(long id)
        {
            return _personRepository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _personRepository.Update(person);
        }

    }
}
