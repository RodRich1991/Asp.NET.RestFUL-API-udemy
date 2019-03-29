using RestWithAsp.NET_core.UDEMY.V1.Model;
using RestWithAsp.NET_core.UDEMY.V1.Repository.Base;
using System.Collections.Generic;

namespace RestWithAsp.NET_core.UDEMY.V1.Service.Implementation
{
    public class PersonServiceImpl : IPersonService
    {
        private IBaseRepository<Person> _baseRepository;

        public PersonServiceImpl(IBaseRepository<Person> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public Person Create(Person person)
        {
            return _baseRepository.Create(person);
        }

        public void Delete(long id)
        {
            _baseRepository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _baseRepository.FindAll();
        }

        public Person FindById(long id)
        {
            return _baseRepository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _baseRepository.Update(person);
        }

    }
}
