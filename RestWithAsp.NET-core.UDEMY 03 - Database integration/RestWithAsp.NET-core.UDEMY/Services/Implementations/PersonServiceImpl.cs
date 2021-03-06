﻿using RestWithAsp.NET_core.UDEMY.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RestWithAsp.NET_core.UDEMY.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private MySQLContext _mySQLContext;

        public PersonServiceImpl(MySQLContext mySQLContext)
        {
            _mySQLContext = mySQLContext;
        }

        public Person Create(Person person)
        {
            try
            {
                _mySQLContext.Add(person);
                _mySQLContext.SaveChanges();
                return person;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(long id)
        {
            var fromDb = _mySQLContext.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (fromDb != null)
            {
                _mySQLContext.Persons.Remove(fromDb);
                _mySQLContext.SaveChanges();
            }
        }

        public List<Person> FindAll()
        {
            return _mySQLContext.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return _mySQLContext.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person)
        {
            if (!Exist(person.Id))
                return new Person();
            var personFromDb = _mySQLContext.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
            try
            {
                _mySQLContext.Entry(personFromDb).CurrentValues.SetValues(person);
                _mySQLContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        private bool Exist(long? id)
        {
            return _mySQLContext.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
