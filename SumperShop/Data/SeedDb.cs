using Microsoft.AspNetCore.Identity;
using SumperShop.Data.Entities;
using SumperShop.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumperShop.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        //private readonly UserManager<User> _userManager;
        private Random _random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            this._context = context;
            this._userHelper = userHelper;
          //  this._userManager = userManager;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await this._context.Database.EnsureCreatedAsync();

            // Teste user__
            var user = await this._userHelper.GetUserByEmailAsync("a44502@alunos.isel.pt");

            if (user == null)
            {
                user = new User
                {
                    FirstName = "Edson",
                    LastName = "Canganjo",
                    Email = "a44502@alunos.isel.pt",
                    UserName = "a44502@alunos.isel.pt",
                    PhoneNumber = "936546585"
                };

                var result = await this._userHelper.AddUserAsync(user, "123456");

                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!this._context.Products.Any())
            {
                AddProduct("iPhone X", user);
                AddProduct("Magic Mouse", user);
                AddProduct("iWatch Series 4", user);
                AddProduct("iPad Mini", user);
                // Get the values from the context and send them to DB
                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name, User user)
        {
            this._context.Products.Add(
                new Product
                {
                    Name = name,
                    Price = _random.Next(1000),
                    IsAvailable = true,
                    Stock = _random.Next(100),
                    User = user
                });
        }
    }
}
