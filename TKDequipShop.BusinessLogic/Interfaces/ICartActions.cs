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

        public CartResponseDto PostItemToCartAction(int _userId, CartItemData _item);

        public CartResponseDto DeleteCartItemAction(int _userId, int _itemId);

        public bool ClearCartAction(int _userId);
    }
}
