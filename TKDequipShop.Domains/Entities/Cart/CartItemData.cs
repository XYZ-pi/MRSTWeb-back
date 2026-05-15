using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Product;

namespace TKDequipShop.Domains.Entities.Cart
{
    public class CartItemData
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        //public CartData Cart { get; set; }
        public int ProductId { get; set; }
        //public ProductData Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
