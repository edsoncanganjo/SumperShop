using SumperShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumperShop.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private Random _random;

        public SeedDb(DataContext context)
        {
            this._context = context;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await this._context.Database.EnsureCreatedAsync();

            if (!this._context.Products.Any())
            {
                AddProduct("iPhone X");
                AddProduct("Magic Mouse");
                AddProduct("iWatch Series 4");
                AddProduct("iPad Mini");
                // Get the values from the context and send them to DB
                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            this._context.Products.Add(
                new Product
                {
                    Name = name,
                    Price = _random.Next(1000),
                    IsAvailable = true,
                    Stock = _random.Next(100)
                });
        }
    }
}
