using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Order;
using TKDequipShop.Domains.Enums.Order;

namespace TKDequipShop.Domains.Models.Order
{
    public class OrderResponseDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<OrderItemData> Items { get; set; } = new List<OrderItemData>();
        public decimal TotalPrice { get; set; }
        public OrderStatus Status { get; set; }
    }
}
