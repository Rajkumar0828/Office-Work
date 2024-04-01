using LoginDemo1.Model;
using Microsoft.AspNetCore.Mvc;
using LoginDemo1.ApiModel;
using LoginDemo1.DataContext;
using LoginDemo1.OtherOperation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using System.Linq;
//using Org.BouncyCastle.Security;
//using System.Globalization;

namespace LoginDemo1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    
    public class SignUpController : ControllerBase

    {
        private ApplicationDbContext _context;
        private IConfiguration _configuration;
        public SignUpController(ApplicationDbContext context,IConfiguration configuration) 
        {
            _context = context;
            _configuration= configuration;
        }
        //POST api/<AuthController>
        [HttpPost]
        
        public IActionResult PostUser(SignUpModel user)
        {
            List<Claim> authClaim;
            string token;
            SignUpMessageModel message=null;
            User user1 = new User()
            {
                UserId = Guid.NewGuid().ToString(),
                UserName = user.UserName,
                Email = user.Email,
                Password = SHA256Encrypt.ComputePasswordToSha256Hash(user.Password),
                MobileNumber = user.MobileNumber,
                LockoutEnabled = false,
               

            };
            Roles role = _context.Roles.FirstOrDefault(role => role.Name == user.Role)!;
            UserRole userrole = new UserRole()
            {
                Id = Guid.NewGuid().ToString(),
                User = user1,
                Role = role
            };

            if (_context.User.Any(user => user.Email == user1.Email) || _context.User.Any(user => user.MobileNumber == user1.MobileNumber))
            {
                if (_context.User.Any(user => user.Email == user1.Email))
                {

                   
                    
                    message = new SignUpMessageModel()
                    {
                        EmailExists= true,
                        MobileNumberExists= false,
                        Username=null,
                        Token=null

                    };
                }
                if (_context.User.Any(user => user.MobileNumber == user1.MobileNumber))
                {
                    message = new SignUpMessageModel()
                    {
                        EmailExists = false,
                        MobileNumberExists = true,
                        Username = null,
                        Token = null

                    };
                   
                }
                if (_context.User.Any(user => user.MobileNumber == user1.MobileNumber)&& _context.User.Any(user => user.Email == user1.Email))
                {
                    message = new SignUpMessageModel()
                    {
                        EmailExists = true,
                        MobileNumberExists = true,
                        Username = null,
                        Token = null

                    };
                   
                }

                
                return Ok(message);
            }
            _context.User.Add(user1);
            _context.UserRole.Add(userrole);
            if (_context.SaveChanges() > 0)
            {
                User resuser=_context.User.FirstOrDefault(user => user.UserName== user1.UserName)!;
                UserRole resuserrole = _context.UserRole.FirstOrDefault(userrole=>userrole.User==resuser)!;
                authClaim = new List<Claim>
                {
                    new Claim("Id",resuser.UserId),
                    new Claim("Role",resuserrole.Role.RolesId),
                    //JWTID
                    //new Claim("AccessKey",Guid.NewGuid().ToString())
                };
                token=GenerateJWTToken(authClaim);
                message = new SignUpMessageModel()
                {
                    EmailExists=false,
                    MobileNumberExists=false,
                    Token=token,
                    Username=resuser.UserName 
                };
                return Ok(message);
            }
            return BadRequest("Internal Server Error ! Please try again later");
        }
        [HttpPost]
        public IActionResult PostRole([FromBody] Roles roles)
        {
            Roles roles1 = new Roles()
            {
                RolesId = Guid.NewGuid().ToString(),
                Name = roles.Name.ToUpper()
            };
            _context.Roles.Add(roles1);
            _context.SaveChanges();
            return Ok();
        }
        [NonAction]
        public string GenerateJWTToken(List<Claim> authClaims)
        {
            
            var authSecret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]!));
            var tokenObject = new JwtSecurityToken(
               issuer: _configuration["JWT:ValidIssuer"],
               audience: _configuration["JWT:ValidAudience"],
               expires: DateTime.Now.AddDays(2),
               claims: authClaims,
               signingCredentials: new SigningCredentials(authSecret, SecurityAlgorithms.HmacSha256)
               );

            string token = new JwtSecurityTokenHandler().WriteToken(tokenObject);
            return token;
        }
    }
}
