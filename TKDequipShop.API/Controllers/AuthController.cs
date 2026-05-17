using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TKDequipShop.BusinessLogic;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.DataAccess.Context;
using TKDequipShop.Domains.Models.Auth;


namespace TKDequipShop.API.Controllers
{
    [Route("api/session")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthActions _authActions;

        public AuthController()
        {
            var _bl = new TKDequipShop.BusinessLogic.BusinessLogic();
            _authActions = _bl.GetAuthActions();
        }

        [HttpPost("auth")]
        public IActionResult Login([FromBody] LoginDto _login)
        {
            var token = _authActions.LoginAction(_login);
            if (token == null) return Unauthorized("Invalid credentials");
            return Ok(new { token });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterDto _register)
        {
            var token = _authActions.RegisterAction(_register);
            if (token == null) return BadRequest("User already exists");
            return Ok(new { token });
        }
        [HttpGet("me")]
        [Authorize]
        public IActionResult GetCurrentUser()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var user = _authActions.GetUserByIdAction(userId);
            if (user == null) return NotFound();

            return Ok(new
            {
                id = user.Id,
                userName = user.UserName,
                email = user.Email,
                role = user.Role.ToString(),
                isActive = user.IsActive,
                createdAt = user.CreatedAt
            });
        }
    }
}
