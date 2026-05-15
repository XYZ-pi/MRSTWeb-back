using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Cart;
using TKDequipShop.Domains.Models.Cart;

namespace TKDequipShop.BusinessLogic.Interfaces
{
    public interface ICartActions
    {
        public CartResponseDto GetCartByUserIdAction(int _userId);

        public CartResponseDto PostItemToCart(int _userId, CartItemData _item);

    }
}
