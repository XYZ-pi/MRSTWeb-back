using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Models.Cart;

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


    }
}
