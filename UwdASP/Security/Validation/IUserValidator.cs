using System.Collections.Generic;
using System.Threading.Tasks;
using UwdASP.API.Models;

namespace UwdASP.Security.Validation
{
    public interface IUserValidator
    {
        Task<string> ValidateLogin(LoginRequest request);
        Task<string> ValidateRegister(RegisterRequest request);
    }
}
