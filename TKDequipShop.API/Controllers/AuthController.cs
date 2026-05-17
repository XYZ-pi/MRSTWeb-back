using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TKDequipShop.BusinessLogic;
using TKDequipShop.DataAccess.Context;
using TKDequipShop.Domains.Models.Auth;

namespace TKDequipShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly AppDbContext _db = new AppDbContext();
        private readonly TokenService _tokenService = new TokenService();

        [HttpPost("auth")]
        public IActionResult Login([FromBody] LoginDto _login)
        {
            var user = _db.UserDatas.FirstOrDefault(u =>
                u.UserName == _login.UserName &&
                u.Password == _login.Password);

            if (user == null) return Unauthorized("Invalid credentials");

            var token = _tokenService.GenerateToken(user);
            return Ok(new { token });
        }
    }
}
