using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace UwdASP.Data.Models
{
    public enum UserType
    {
        Student,
        Teacher
    }

    public class User : IdentityUser<long>
    {
        [Required]
        public UserType UserType { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
