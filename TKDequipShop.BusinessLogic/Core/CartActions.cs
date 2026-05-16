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

        public CartItemData ExecutePostItemToCartAction(int _userId, CartItemData _item)
        {
            var CartToFound = carts.FirstOrDefault(c => c.UserId == _userId);
            if (CartToFound == null) return null;
            CartToFound.Items.Add(_item);
            return _item;
        }

        public CartData ExecuteDeleteCartItemAction(int _userId, int _itemId)
        {
            var cart = carts.FirstOrDefault(c => c.UserId == _userId);
            if (cart == null) return null;
            var item = cart.Items.FirstOrDefault(i => i.Id == _itemId);
            if (item == null) return null;
            cart.Items.Remove(item);
            return cart;
        }

        public bool ExecuteClearCartAction(int _userId)
        {
            var cart = carts.FirstOrDefault(c => c.UserId == _userId);
            if (cart == null) return false;
            cart.Items.Clear();
            cart.TotalPrice = 0;
            return true;
        }

    }
}
