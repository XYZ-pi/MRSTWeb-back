using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Order;

namespace TKDequipShop.Domains.Models.Order
{
    public class OrderCreateDto
    {
        public int UserId { get; set; }
        public List<OrderItemData> Items { get; set; } = new List<OrderItemData>();
    }
}

