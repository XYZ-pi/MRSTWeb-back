using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Enums.Order;

namespace TKDequipShop.Domains.Entities.Order
{
    public class OrderData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<OrderItemData> Items { get; set; } = new List<OrderItemData>();
        public decimal TotalPrice { get; set; }
        public OrderStatus Status { get; set; }
    }
}
