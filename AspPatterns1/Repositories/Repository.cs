using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspPatterns1.Repositories
{
    public class Repository<T> : IRepository<T>
    {

        public IEnumerable<T> GetAll(int category)
        {
            throw new NotImplementedException();
        }

        public T GetSingleById(System.Linq.Expressions.Expression<Func<T, bool>> predicateId)
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}