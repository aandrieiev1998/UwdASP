using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using UwdASP.API.Models;
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

        public async Task<IActionResult> Add([FromBody] AddMarkRequest request)
        {
            return null;
        }

        [HttpGet]
        [AuthorizeToken]
        public async Task<IActionResult> Marks([FromQuery]long userId)
        {
            var user = await UserManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var marksByLesson = new Dictionary<string, List<string>>();
            
            if (user.UserType == UserType.Teacher)      // оценки для препода (список оценок студента у указанного препода)
            {
                var marks = DbContext.Marks
                    .Where(m => m.StudentData.Identity.Id == userId && m.TeacherData.Identity.Id == user.Id)
                    .ToList();

                var results = from m in marks
                    group m by m.LessonId
                    into ml
                    select new {Lesson = ml.Key, Marks = ml.Select(ml_ => new
                    {
                        Value = ml_.Value,
                        Date = ml_.Date,
                        Type = ml_.MarkType.ToString(),

                    }).ToList()};

                return new OkObjectResult(results);
            }
            else
            {
                return new BadRequestObjectResult("Server error: marks for students are not implemented yet!");
            }
        }

    }
}
