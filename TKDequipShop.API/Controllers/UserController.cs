using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Models.User;
using TKDequipShop.BusinessLogic;
using TKDequipShop.BusinessLogic.Functions;
using Microsoft.AspNetCore.Authorization;
using TKDequipShop.API.Attributes;


namespace TKDequipShop.API.Controllers
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
        [AdminMod]
        public IActionResult GetAllUsers()
        {
            var _users = _userActions.GetAllUsersAction();
            return Ok(_users);
        }

        [HttpPost]
        [AdminMod]
        public IActionResult CreateNewUser(UserCreateDto _user)
        {
            var _newUser = _userActions.CreateNewUserAction(_user);
            return Created($"/api/user/{_newUser.Id}", _newUser);
        }

        [HttpPut("{id}")]
        [UserMod]
        public IActionResult UpdateUser(int id, UserCreateDto _user)
        {
            var _updatedUser = _userActions.UpdateUserAction(id, _user);

            if (_updatedUser == null) return NotFound();

            return Ok(_updatedUser);
        }

        [HttpDelete("{id}")]
        [AdminMod]
        public IActionResult DeleteUser(int id)
        {
            var IsDeleted = _userActions.DeleteUserAction(id);

            if (!IsDeleted) return NotFound();

            return NoContent();
        }

        [HttpGet("{id}")]
        [UserMod]
        public IActionResult GetUserById(int id)
        {
            var _user = _userActions.GetUserByIdAction(id);

            if (_user == null) return NotFound();

            return Ok(_user);
        }
    }
}
