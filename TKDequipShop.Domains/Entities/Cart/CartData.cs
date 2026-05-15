using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Refs;
using TKDequipShop.Domains.Entities.User;
using TKDequipShop.Domains.Enums.Cart;

namespace TKDequipShop.Domains.Entities.Cart
{
    public class CartData : SharedFields
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        //public UserData User { get; set; }
        public List<CartItemData> Items { get; set; } = new List<CartItemData>();
        public decimal TotalPrice { get; set; }
        public CartStatus Status { get; set; }
        
    }
}
