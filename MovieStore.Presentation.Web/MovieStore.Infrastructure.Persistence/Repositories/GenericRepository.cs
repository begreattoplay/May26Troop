using MovieStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Infrastructure.Persistence.Repositories
{
    public class GenericRepository : IRepository
    {
        private ApplicationDbContext _dataContext = new ApplicationDbContext();

        public void Add<T>(T entityToCreate) where T : class
        {
            _dataContext.Set<T>().Add(entityToCreate);
        }

        public void Delete<T>(params object[] keyValues) where T : class
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Find<T>(params object[] keyValues) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable Query(string entityTypeName)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
