using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Entities.Cart;

namespace TKDequip.API.Controllers
{
    [Route("api/cart")]
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
        public IActionResult PostItemToCart(int _userId, [FromBody]CartItemData _item)
        {
            var _cart = _cartActions.PostItemToCartAction(_userId, _item);
            if (_cart == null) return BadRequest();
            return Ok(_cart);
        }

        [HttpDelete("{_userId}/items/{_itemId}")]
        public IActionResult DeleteCartItem(int _userId, int _itemId)
        {
            var _cart = _cartActions.DeleteCartItemAction(_userId, _itemId);
            if (_cart == null) return NotFound();
            return Ok(_cart);
        }

        [HttpDelete("{_userId}")]
        public IActionResult ClearCart(int _userId)
        {
            var result = _cartActions.ClearCartAction(_userId);
            if (!result) return NotFound();
            return Ok();
        }

    }
}
