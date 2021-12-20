using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SumperShop.Data.Entities;

namespace SumperShop.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        /// <summary>
        /// Set DataContext for the Repository
        /// </summary>
        /// <param name="context"></param>
        public Repository(DataContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Get the list of all products
        /// </summary>
        /// <returns>Products</returns>
        public IEnumerable<Product> GetProducts()
        {
            return this._context.Products.OrderBy(p => p.Name);
        }

        /// <summary>
        /// Get the Product according to the id given
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product</returns>
        public Product GetProduct(int id)
        {
            return this._context.Products.Find(id);
        }

        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            this._context.Products.Add(product);
        }

        /// <summary>
        /// Update product from products
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(Product product)
        {
            this._context.Products.Update(product);
        }

        /// <summary>
        /// Remove product from products
        /// </summary>
        /// <param name="product"></param>
        public void DeleteProduct(Product product)
        {
            this._context.Products.Remove(product);
        }

        /// <summary>
        /// Save All changes to database
        /// </summary>
        /// <returns>Task<bool></returns>
        public async Task<bool> SaveAllAsync()
        {
            return await this._context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Check whetter or not the product exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool</returns>
        public bool ProductExists(int id)
        {
            return this._context.Products.Any(p => p.Id == id);
        }
    }
}
