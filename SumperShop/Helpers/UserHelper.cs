using Microsoft.AspNetCore.Identity;
using SumperShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumperShop.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> _userManager;

        public UserHelper(UserManager<User> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await this._userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await this._userManager.FindByEmailAsync(email);
        }
    }
}
