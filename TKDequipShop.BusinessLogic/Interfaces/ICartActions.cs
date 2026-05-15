using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Models.Cart;

namespace TKDequipShop.BusinessLogic.Interfaces
{
    public interface ICartActions
    {
        public CartResponseDto GetCartByUserIdAction(int _userId);
    }
}
