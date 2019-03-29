using Microsoft.EntityFrameworkCore;
using RestWithAsp.NET_core.UDEMY.v1.Model.Base;
using RestWithAsp.NET_core.UDEMY.V1.Model.Context;
using RestWithAsp.NET_core.UDEMY.V1.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithAsp.NET_core.UDEMY.V1.Repository.Implementation.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        private readonly MySQLContext _mySQLContext;
        private DbSet<T> _dbSet;

        public BaseRepository(MySQLContext mySQLContext)
        {
            _mySQLContext = mySQLContext;
            _dbSet = _mySQLContext.Set<T>();
        }

        public T Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _mySQLContext.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(long id)
        {
            var fromDb = _dbSet.SingleOrDefault(e => e.Id.Equals(id));
            if (fromDb != null)
            {
                _dbSet.Remove(fromDb);
                _mySQLContext.SaveChanges();
            }
        }

        public List<T> FindAll()
        {
            return _dbSet.ToList();
        }

        public T FindById(long id)
        {
            return _dbSet.SingleOrDefault(e => e.Id.Equals(id));
        }

        public T Update(T entity)
        {
            if (!Exist(entity.Id))
                return null;
            var entityFromDb = _dbSet.SingleOrDefault(e => e.Id.Equals(entity.Id));
            try
            {
                _mySQLContext.Entry(entityFromDb).CurrentValues.SetValues(entity);
                _mySQLContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public bool Exist(long? id)
        {
            return _dbSet.Any(e => e.Id.Equals(id));
        }

    }
}
