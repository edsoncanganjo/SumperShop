using Microsoft.AspNetCore.Identity;
using SumperShop.Data.Entities;
using SumperShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumperShop.Helpers
{
    public class UserHelper : IUserHelper
    {
        // Manage user, wetther or not exists on db, and their informations relacted
        private readonly UserManager<User> _userManager;
        // Mange authentications login, logout, signin
        private readonly SignInManager<User> _signInManager;

        public UserHelper(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await this._userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await this._userManager.FindByEmailAsync(email);
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            return await this._signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);
        }

        public async Task LogoutAsync()
        {
            await this._signInManager.SignOutAsync();
        }
    }
}
