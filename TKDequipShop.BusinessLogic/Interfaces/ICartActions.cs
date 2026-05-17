using TKDequipShop.Domains.Entities.Cart;
using TKDequipShop.Domains.Models.Cart;

namespace TKDequipShop.BusinessLogic.Interfaces
{
    public interface ICartActions
    {
        public CartResponseDto GetCartByUserIdAction(int _userId);

        public CartResponseDto PostItemToCartAction(int _userId, CartItemDto _item);

        public CartResponseDto DeleteCartItemAction(int _userId, int _itemId);

        public bool ClearCartAction(int _userId);
    }
}
