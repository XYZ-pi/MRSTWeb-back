using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Enums.Order;
using TKDequipShop.Domains.Models.Order;

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

        [HttpGet("{_userId}")]
        public IActionResult GetAllOrdersOfUser(int _userId)
        {
            var _orders = _orderActions.GetAllOrdersOfUserAction(_userId);
            return Ok(_orders);
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderCreateDto _order)
        {
            var order = _orderActions.CreateOrderAction(_order);
            if (order == null) return BadRequest();
            return Ok(order);
        }

        [HttpPut("{_orderId}/status")]
        public IActionResult UpdateOrderStatus(int _orderId, [FromBody] OrderStatus _status)
        {
            var order = _orderActions.UpdateOrderStatusAction(_orderId, _status);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpDelete("{_orderId}")]
        public IActionResult DeleteOrder(int _orderId)
        {
            var result = _orderActions.DeleteOrderAction(_orderId);
            if (!result) return NotFound();
            return NoContent();
        }

        

    }
}
