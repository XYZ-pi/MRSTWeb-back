using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Models.Cart;
using TKDequipShop.Domains.Entities.Cart;


namespace TKDequipShop.BusinessLogic.Core
{
    public class CartActions
    {
        static List<CartData> carts = new List<CartData>();


        public CartData ExecuteGetCartByUserIdAction(int _userId)
        {
            var CartToFound = carts.FirstOrDefault(c => c.UserId == _userId);

            if (CartToFound == null) return null;

            return CartToFound;
        }

        public CartItemData ExecutePostItemToCart(int _userId, CartItemData _item)
        {
            var CartToFound = carts.FirstOrDefault(c => c.UserId == _userId);
            if (CartToFound == null) return null;
            CartToFound.Items.Add(_item);
            return _item;
        }
    }
}
