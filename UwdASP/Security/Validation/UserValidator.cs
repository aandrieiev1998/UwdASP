using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using UwdASP.API.Models;
using UwdASP.Data;
using UwdASP.Data.Models;

namespace UwdASP.Security.Validation
{
    public class UserValidator : IUserValidator
    {

        protected UwdDbContext DbContext;
        protected UserManager<User> UserManager;
        protected SignInManager<User> SignInManager;

        public UserValidator(UwdDbContext dbContext, UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            DbContext = dbContext;
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public async Task<string> ValidateLogin(LoginRequest request)
        {
            var username = request.Username;
            var password = request.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Credentials were not provided";
            }

            var user = await UserManager.FindByNameAsync(username);
            if (user == null)
            {
                return $"User '{username}' not found!";
            }

            var signInResult = await SignInManager.CheckPasswordSignInAsync(user, password, false);
            if (!signInResult.Succeeded)
            {
                return "Invalid password provided!";
            }

            var activeSessionExists = DbContext.Sessions
                .Any(session => session.UserId == user.Id && session.IsActive);
            if (activeSessionExists)
            {
                return $"User {username} already logged in!";
            }

            return null;
        }

        public async Task<string> ValidateRegister(RegisterRequest request)
        {
            return null;
        }

    }
}
