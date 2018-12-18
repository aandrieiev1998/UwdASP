using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UwdASP.Data;

namespace UwdASP.Controllers
{
    public class MarksController : Controller
    {
        protected UwdDbContext DbContext;

        public MarksController(UwdDbContext dbContext)
        {
            DbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("There will be some marks");
        }
    }
}
