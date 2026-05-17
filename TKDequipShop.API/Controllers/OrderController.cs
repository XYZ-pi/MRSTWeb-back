using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Enums.Order;
using TKDequipShop.Domains.Models.Order;
using TKDequipShop.API.Attributes;
using System.Security.Claims;

namespace TKDequipShop.API.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderActions _orderActions;
        public OrderController()
        {
            var _bl = new TKDequipShop.BusinessLogic.BusinessLogic();
            _orderActions = _bl.GetOrderActions();
        }

        [HttpGet("{my}")]
        [UserMod]
        public IActionResult GetAllOrdersOfUser(int _userId)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized("Не удалось определить пользователя из токена");

            var orders = _orderActions.GetAllOrdersOfUserAction(userId);
            return Ok(orders);
        }

        [HttpPost]
        [UserMod]
        public IActionResult CreateOrder([FromBody] OrderCreateDto _order)
        {
            var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized("Не удалось определить пользователя из токена");

            var order = _orderActions.CreateOrderAction(userId, _order);
            if (order == null) return BadRequest("Ошибка создания заказа");
            return Ok(order);
        }

        [HttpPut("{_orderId}/status")]
        [ManagerMod]
        public IActionResult UpdateOrderStatus(int _orderId, [FromBody] OrderStatus _status)
        {
            var order = _orderActions.UpdateOrderStatusAction(_orderId, _status);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpDelete("{_orderId}")]
        [AdminMod]
        public IActionResult DeleteOrder(int _orderId)
        {
            var result = _orderActions.DeleteOrderAction(_orderId);
            if (!result) return NotFound();
            return NoContent();
        }

        

    }
}
