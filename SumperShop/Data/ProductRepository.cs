using Microsoft.EntityFrameworkCore;
using SumperShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumperShop.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context) : base(context)
        {
            this._context = context;
        }

        public IQueryable GetAllWithUsers()
        {
            return _context.Products.Include(p => p.User);
        }
    }
}
