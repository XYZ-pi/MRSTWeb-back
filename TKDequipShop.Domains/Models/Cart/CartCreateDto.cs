using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Cart;
using TKDequipShop.Domains.Enums.Cart;

namespace TKDequipShop.Domains.Models.Cart
{
    public class CartCreateDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<CartItemData> Items { get; set; } = new List<CartItemData>();
        public decimal TotalPrice { get; set; }
        public CartStatus Status { get; set; }
    }
}
