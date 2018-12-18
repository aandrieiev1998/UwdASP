using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using UwdASP.Data;
using UwdASP.Data.Models;
using UwdASP.Security;

namespace UwdASP.Controllers
{
    public class MarksController : Controller
    {
        protected UwdDbContext DbContext;
        protected UserManager<User> UserManager;

        public MarksController(UwdDbContext dbContext, UserManager<User> userManager)
        {
            DbContext = dbContext;
            UserManager = userManager;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("There will be some marks");
        }


        [HttpGet]
        [AuthorizeToken]
        public async Task<IActionResult> Marks([FromQuery]long userId)
        {
            var user = await UserManager.FindByNameAsync(HttpContext.User.Identity.Name);
            if (user.UserType == UserType.Teacher)      // оценки для препода (список оценок студента у указанного препода)
            {
                var marks = DbContext.Marks
                    .Where(m => m.StudentData.Identity.Id == userId && m.TeacherData.Identity.Id == user.Id)
                    .Select(m => new JObject(
                        new JProperty("ocena", m.Value),
                        new JProperty("przedmiot", m.Lesson.Name),
                        new JProperty("rodzaj", m.MarkType.ToString()),
                        new JProperty("komentarz", m.Comment),
                        new JProperty("data", m.Date)))
                    .ToList();
                return new OkObjectResult(marks);
            }
            else
            {
                return new BadRequestObjectResult("Server error: marks for students are not implemented yet!");
            }
        }

    }
}
