using System;
using System.Collections.Generic;
using System.Threading;

namespace RestWithAsp.NET_core.UDEMY.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            person.Id = IncrementAndGetId();
            return person;
        }

        public void Delete(long id)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();
            for (long r = 1; r <= 8; r++)
            {
                people.Add(MockPerson(r));
            }
            return people;
        }

        public Person FindById(long id)
        {
            return MockPerson(id);
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson()
        {
            return MockPerson(IncrementAndGetId());
        }

        private Person MockPerson(long id)
        {
            return new Person
            {
                Id = id,
                FirstName = "Person Name " + id,
                LastName = "Person Last Name " + id,
                Address = "Some address "+ id,
                Gender = "Male"
            };
        }

        private long IncrementAndGetId()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
