using AspPatterns1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspPatterns1.Repositories
{
    public class ProductRepository : IRepository<T>
    {

        DbContext myContext;

        public ProductRepository(DbContext theContext)
        {
            myContext = theContext;
        }

        public IEnumerable<Product> GetAll(int category)
        {
            throw new NotImplementedException();
        }

        public Product GetSingleById(System.Linq.Expressions.Expression<Func<Product, bool>> predicateId)
        {
            throw new NotImplementedException();
        }

        public void Add(Product item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product item)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}