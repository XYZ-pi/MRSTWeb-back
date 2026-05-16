using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Models.Cart;
using TKDequipShop.Domains.Entities.Cart;

namespace TKDequipShop.BusinessLogic.Functions
{
    public class CartFlow : CartActions, ICartActions
    {
        public CartResponseDto GetCartByUserIdAction(int _userId)
        {
            var cart = ExecuteGetCartByUserIdAction(_userId);

            if (cart == null) return null;
            CartResponseDto cartDto = new CartResponseDto()
            {
                Id = cart.Id,
                UserId = cart.UserId,
                Items = cart.Items,
                Status = cart.Status,

            };

            return cartDto;
        }

        public CartResponseDto PostItemToCartAction(int _userId, CartItemData _item)
        {
            var item = ExecutePostItemToCartAction(_userId, _item);
            if (item == null) return null;
            var cart = ExecuteGetCartByUserIdAction(_userId);
            CartResponseDto cartDto = new CartResponseDto()
            {
                Id = cart.Id,
                UserId = cart.UserId,
                Items = cart.Items,
                Status = cart.Status,
            };
            return cartDto;
        }

        public CartResponseDto DeleteCartItemAction(int _userId, int _itemId)
        {
            var cart = ExecuteDeleteCartItemAction(_userId, _itemId);
            if (cart == null) return null;
            return new CartResponseDto()
            {
                Id = cart.Id,
                UserId = cart.UserId,
                Items = cart.Items,
                Status = cart.Status,
            };
        }

        public bool ClearCartAction(int _userId)
        {
            return ExecuteClearCartAction(_userId);
        }

    }
}
