using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using WebApp.Models;
using WebApp.ViewModel;

namespace WebApp.Controllers
{
    [Route("api/controller")]
    [ApiController]

    public class LoginController : Controller
    {
        CourseDbContext db = new CourseDbContext();
        IConfiguration config;

        public LoginController(IConfiguration configuration)
        {
            config = configuration;
        }

        [HttpPost]
        public IActionResult login(LoginViewModel login)
        {
            IActionResult respose = Unauthorized();
            var user = ValidateUser(login);
            if (user != null)
            {
                var tokenString = GenerateToken(user);
                if (tokenString.IsNullOrEmpty())
                {
                    respose = Ok(new { Status = 200, Message = "Some error occured" });
                }
                respose = Ok(new { Status = 200, Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
            return respose;
        }

        [NonAction]
        private LoginViewModel ValidateUser(LoginViewModel login)
        {
            if (db.Login.Any(x => x.UserName == login.UserName && x.Password == login.Password))
            {
                return login;
            }
            else
            {
                return null;
            }
        }
        [NonAction]
        private string GenerateToken(LoginViewModel login)
        {
            try
            {
                var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Key"]));
                var crdentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    config["JWT:Issuer"],
                     config["JWT:Audience"],
                     null,
                     null,
                     DateTime.Now.AddMinutes(120),
                     crdentials
                    );
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                return "";
            }
        }
   
    }
}
