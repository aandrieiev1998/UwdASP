using Microsoft.AspNetCore.Identity;
using UwdASP.Data;
using UwdASP.Data.Models;

namespace UwdASP.Controllers
{
    public class UsersController
    {
        protected UwdDbContext DbContext;
        protected UserManager<User> UserManager;
        protected SignInManager<User> SignInManager;

        public UsersController(UwdDbContext dbContext, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            DbContext = dbContext;
            UserManager = userManager;
            SignInManager = signInManager;
        }
    }
}
