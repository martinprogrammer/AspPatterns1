using AspPatterns1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace AspPatterns1.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(int category);
        T GetSingleById(Expression<Func<T, bool>> predicateId);
        void Add(T item);
        void Remove(T item);
        void Update(T item);
    }
}