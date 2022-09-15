using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using AutomicObjectDesignerBack.Repository;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesigner.Models.Registration;
// Install-Package BCrypt.Net-Next

namespace AutomicObjectDesignerBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorizationController : Controller
    {
        public IConfiguration Configuration { get; }
        //private readonly IAuthorizationRepository _authorizationRepository;

        public AuthorizationController(AppDatabaseContext context, IConfiguration configuration/*, IAuthorizationRepository repository*/)
        {
            //_authorizationRepository = repository;
            Configuration = configuration;
        }

        public static UserModel user = new UserModel();

        [HttpPost("register")]
        public async Task<ActionResult<UserModel>> Register(UserLogin request)
        {
            //var user = new UserModel();
            user.UserName = request.UserName;
            user.Password = /*HashPassword(request);*/ request.Password;

            //_authorizationRepository.Create(user);
            //await _authorizationRepository.Save();
            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserLogin request)
        {
            //var user = _authorizationRepository.FindByCondition(x => x.UserName == request.UserName);
            if (user == null)
            {
                return BadRequest("User not found");
            }
            //request.Password = VerifyHashedPassword(user, request.Password);
            string token = CreateToken(user);
            return Ok(token);
        }

        private string CreateToken(UserModel user)
        {
            List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.UserName)
        };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(Configuration.GetSection("Jwt:Key").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
        //public string HashPassword(UserModel user)
        //{
        //    return BCrypt.Net.BCrypt.HashPassword(user.Password, 8);
        //}
        //public PasswordVerificationResult VerifyHashedPassword(
        //  UserModel user, string providedPassword)
        //{
        //    var isValid = BCrypt.Net.BCrypt.Verify(providedPassword, user.Password);

        //    if (isValid && BCrypt.Net.BCrypt.PasswordNeedsRehash(user.Password, 8))
        //    {
        //        return PasswordVerificationResult.SuccessRehashNeeded;
        //    }

        //    return isValid ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
        //}
    }
}
