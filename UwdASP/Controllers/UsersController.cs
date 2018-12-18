using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using UwdASP.API.Models;
using UwdASP.Data;
using UwdASP.Data.Models;
using UwdASP.Security;
using UwdASP.Security.Validation;

namespace UwdASP.Controllers
{
    public class UsersController : Controller
    {
        protected UwdDbContext DbContext;
        protected UserManager<User> UserManager;
        protected SignInManager<User> SignInManager;
        protected IConfiguration Configuration;
        protected IUserValidator UserValidator;

        public UsersController(IConfiguration configuration, UwdDbContext dbContext, UserManager<User> userManager,
            SignInManager<User> signInManager, IUserValidator userValidator)
        {
            DbContext = dbContext;
            UserManager = userManager;
            SignInManager = signInManager;
            Configuration = configuration;
            UserValidator = userValidator;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginRequest request)
        {
            var error = await UserValidator.ValidateLogin(request);
            if (!string.IsNullOrEmpty(error))
            {
                return new BadRequestObjectResult(new
                {
                    validation_error = error
                });
            }

            var user = await UserManager.FindByNameAsync(request.Username);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expirationTime = DateTime.Now.Add(TimeSpan.FromSeconds(long.Parse(Configuration["Jwt:Expiration"])));

            var token = new JwtSecurityToken(
                issuer: Configuration["Jwt:Issuer"],
                audience: Configuration["Jwt:Audience"],
                claims: claims,
                signingCredentials: credentials,
                expires: expirationTime
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            DbContext.Sessions.Add(new Session
            {
                UserId = user.Id,
                Identity = user,
                Expiration = expirationTime,
                Token = tokenString,
                IsActive = true
            });

            DbContext.SaveChanges();

            return new OkObjectResult(new
            {
                token = tokenString
            }); 
        }

        [HttpPost]
        [AuthorizeToken]
        public async Task<IActionResult> Logout()
        {
            var user = await UserManager.FindByNameAsync(HttpContext.User.Identity.Name);

            var userSession = DbContext.Sessions.SingleOrDefault(session => session.UserId == user.Id && session.IsActive);
            if (userSession != null)
            {
                userSession.IsActive = false;
                DbContext.Sessions.Update(userSession);
                DbContext.SaveChanges();
                return new OkResult();
            }
            else
            {
                return new BadRequestResult();
            }
        }

        [HttpPost]
        [AuthorizeToken]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {
            // TODO: implement user registration

            return new OkResult();
        }

        [HttpGet]
        [AuthorizeToken]
        public async Task<IActionResult> Profile()
        {
            var user = await UserManager.FindByNameAsync(HttpContext.User.Identity.Name);
            object userData = null;

            switch (user.UserType)
            {
                case UserType.Student:
                {
                    userData = DbContext.StudentsData.SingleOrDefault(sd => sd.UserId == user.Id);
                    break;
                }
                case UserType.Teacher:
                {
                    userData = DbContext.TeachersData.SingleOrDefault(td => td.UserId == user.Id);
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return userData != null ? new OkObjectResult(userData) : new OkObjectResult(user);
        }

        [HttpGet]
        [AuthorizeToken]
        public async Task<IActionResult> MyStudents()
        {
            var user = await UserManager.FindByNameAsync(HttpContext.User.Identity.Name);

            if (user.UserType != UserType.Teacher)
            {
                return new UnauthorizedResult();
            }

            var teacherDataId = DbContext.TeachersData
                .Where(td => td.UserId == user.Id)
                .Select(td => td.Id)
                .SingleOrDefault();

            var groupIds = DbContext.TeacherGroups
                .Where(tg => tg.TeacherDataId == teacherDataId)
                .Select(tg => tg.GroupId)
                .ToHashSet();

            var studentsData = DbContext.StudentsData
                .Where(sd => groupIds.Contains(sd.GroupId))
                .Select(sd => new JObject(
                    new JProperty("user_id", sd.Identity.Id),
                    new JProperty("imie", sd.Identity.FirstName),
                    new JProperty("nazwisko", sd.Identity.LastName),
                    new JProperty("kierunek", sd.Specialization.Name),
                    new JProperty("semester", sd.Semester),
                    new JProperty("grupa", sd.Group.Name)))
                .ToList();

            return new OkObjectResult(studentsData);
        }

    }
}