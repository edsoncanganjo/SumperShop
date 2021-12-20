using SumperShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumperShop.Data
{
    public class MockRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(
                new Product { Id = 1, Name = "Ipone 6", IsAvailable = true, Price = 100, Stock = 40 }
                );
            products.Add(
                new Product { Id = 2, Name = "Ipone X", IsAvailable = true, Price = 500, Stock = 50 }
                );
            products.Add(
                new Product { Id = 3, Name = "Ipone 8", IsAvailable = true, Price = 600, Stock = 70 }
                );

            return products;
        }

        public bool ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
