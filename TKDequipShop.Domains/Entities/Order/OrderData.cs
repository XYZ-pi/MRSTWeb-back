using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Enums.Order;

namespace TKDequipShop.Domains.Entities.Order
{
    public class OrderData
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<OrderItemData> Items { get; set; } = new List<OrderItemData>();
        public decimal TotalPrice { get; set; }
        public OrderStatus Status { get; set; }
    }
}
