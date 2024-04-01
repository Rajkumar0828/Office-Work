using Microsoft.Extensions.Options;

using System;

using System.IdentityModel.Tokens.Jwt;

using System.Security.Claims;

using System.Text;

using Microsoft.IdentityModel.Tokens;

using LoginSignup.Models;

using Microsoft.AspNetCore.Mvc;

using LoginSignup.Data;

using System.Linq;



namespace LoginSignup.Controllers

{

    [ApiController]

    [Route("api/[controller]")]

    public class UserController : ControllerBase

    {

        private readonly AppDbContext _context;

        private readonly JwtSettings _jwtsettings;

        public UserController(AppDbContext context, IOptions<JwtSettings> jwtSettings)

        {

            _context = context;

            _jwtsettings = jwtSettings.Value;

        }



        [HttpPost("login")]

        public IActionResult Login([FromBody] UserLoginModel loginuser)

        {

            var user = _context.Signup.FirstOrDefault(u => u.Email == loginuser.Email && u.Password == loginuser.Password);

            if (user == null)

            {

                return NotFound("Invalid username or password");

            }



            var tokenString = GenerateJwtToken(user);

            return Ok(new { Token = tokenString });

        }



        private string GenerateJwtToken(UserSignUpModel user)

        {

            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtsettings.Secret);



            var tokenDescriptor = new SecurityTokenDescriptor

            {

                Subject = new ClaimsIdentity(new Claim[]

                {

                    new Claim(ClaimTypes.Name, user.Id.ToString())

                }),

                Expires = DateTime.UtcNow.AddHours(1), // Token expiration time 

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),

                Issuer = _jwtsettings.Issuer,

                Audience = _jwtsettings.Audience

            };



            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);

        }



        [HttpPost("signup")]

        public IActionResult Signup([FromBody] UserSignUpModel signupuser)

        {

            _context.Signup.Add(signupuser);

            _context.SaveChanges();

            return CreatedAtAction(nameof(Signup), new { id = signupuser.Id }, signupuser);

        }

    }

}