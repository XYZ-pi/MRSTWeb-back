using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TKDequipShop.BusinessLogic.Interfaces;

namespace TKDequip.API.Controllers
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
        
    }
}
