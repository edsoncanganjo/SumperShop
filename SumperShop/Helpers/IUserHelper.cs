using Microsoft.AspNetCore.Identity;
using SumperShop.Data.Entities;
using SumperShop.Models;
using System.Threading.Tasks;

namespace SumperShop.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);
        
        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();
    }
}
