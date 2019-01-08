using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UwdASP.Data;
using UwdASP.Data.Models;
using UwdASP.Security;

namespace UwdASP.Controllers
{
    public class BookkeepingsController : Controller
    {
        protected UwdDbContext DbContext;
        protected UserManager<User> UserManager;

        public BookkeepingsController(UwdDbContext dbContext, UserManager<User> userManager)
        {
            DbContext = dbContext;
            UserManager = userManager;
        }

        [HttpGet]
        [AuthorizeToken]
        public async Task<IActionResult> Get()
        {
            var user = await UserManager.FindByNameAsync(HttpContext.User.Identity.Name);
            if (user.UserType == UserType.Student)
            {
                var bookkeepings = DbContext.Bookkeepings.Where(b => b.StudentData.Identity.Id == user.Id).ToList();
                return new OkObjectResult(bookkeepings);
            }
            else
            {
                return new BadRequestObjectResult("Server error: bookkeepings for teachers are not implemented yet!");
            }
        }
    }
}
