using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspPatterns1.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }

    public class ProductContextInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext myContext)
        {
            myContext.Products.Add(
                new Product {
                    ProductName = "Tootbrush",
                    Category = 1
                });

            myContext.Products.Add(
                new Product {
                    ProductName = "Hair band",
                    Category = 2
                });

            myContext.Products.Add(
                new Product {
                    ProductName = "Asthma Inhaler",
                    Category = 1
                });

            myContext.SaveChanges();
        }
    }
}