using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Models.User;
using TKDequipShop.BusinessLogic;

namespace TKDequip.API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserActions _userActions;

        public UserController()
        {
            var _bl = new TKDequipShop.BusinessLogic.BusinessLogic();
            _userActions = _bl.GetUserActions();
        }

        [HttpGet("all")]
        public IActionResult GetAllUsers()
        {
            var _users = _userActions.GetAllUsersAction();
            return Ok(_users);
        }

    }
}
