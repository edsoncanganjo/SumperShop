using Microsoft.AspNetCore.Identity;
using SumperShop.Data.Entities;
using System.Threading.Tasks;

namespace SumperShop.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
