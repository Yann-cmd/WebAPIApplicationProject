using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPIApplicationProject.Models;

namespace WebAPIApplicationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;

        private readonly PlantFoodContext _context;

        public LoginController(IOptions<JwtSettings> jwtSettings, PlantFoodContext context)
        {
            _jwtSettings = jwtSettings.Value;
            _context = context;
        }

        /// <summary>
        /// Génère un token via les informations de l'utilisateur.
        /// </summary>
        [HttpPost("token")]
        public string GenerateToken(User user)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
{
                new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var tokenOptions = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signinCredentials
            );
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        /// <summary>
        /// Permet à un utilisateur de se connecter.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<UserLogin>> Login(User user)
        {
            var exsitingUser = from storedUser in _context.Users
                               where storedUser.Password.ToLower() == user.Password.ToLower()
                               && storedUser.Username.ToLower() == user.Username.ToLower()
                               select storedUser;

            if (exsitingUser.Any())
            {
                var tokenString = GenerateToken(user);
                return await Task.FromResult(Ok(new UserLogin(){ Email = user.Email, Username = user.Username, Token = tokenString }));
            }
            else
            {
                return await Task.FromResult(Unauthorized());
            }
        }
    }
}
