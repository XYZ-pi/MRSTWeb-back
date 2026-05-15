using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Models.User;
using TKDequipShop.BusinessLogic;
using TKDequipShop.BusinessLogic.Functions;

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

        [HttpPost]
        public IActionResult CreateNewUser(UserCreateDto _user)
        {
            var _newUser = _userActions.CreateNewUserAction(_user);
            return Created($"/api/user/{_newUser.Id}", _newUser);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, UserCreateDto _user)
        {
            var _updatedUser = _userActions.UpdateUserAction(id, _user);

            if (_updatedUser == null) return NotFound();

            return Ok(_updatedUser);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var IsDeleted = _userActions.DeleteUserAction(id);

            if (!IsDeleted) return NotFound();

            return NoContent();
        }
    }
}
