using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Entities.Cart;

namespace TKDequip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private ICartActions _cartActions;
        public CartController()
        {
            var _bl = new TKDequipShop.BusinessLogic.BusinessLogic();
            _cartActions = _bl.GetCartActions();
        }

        [HttpGet("{_userId}")] //get cart by user id
        public IActionResult GetCartByUserId(int _userId)
        {
            var _cart = _cartActions.GetCartByUserIdAction(_userId);
            if (_cart == null) return NotFound();

            return Ok(_cart);
        }

        [HttpPost("{_userId}/items")]
        public IActionResult PostItemToCart(int _userId, CartItemData _item)
        {
            var _cart = _cartActions.PostItemToCart(_userId, _item);
            return Ok(_cart);
        }
        

    }
}
