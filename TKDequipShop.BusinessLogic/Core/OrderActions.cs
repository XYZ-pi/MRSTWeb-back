using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Order;
using TKDequipShop.Domains.Entities.Product;
using TKDequipShop.Domains.Enums.Order;
using TKDequipShop.Domains.Models.Order;

namespace TKDequipShop.BusinessLogic.Core
{
    public class OrderActions
    {
        static List<OrderData> orders = new List<OrderData>();
        static int _nextId = 1;
        public List<OrderData> GetAllOrdersOfUserAction(int _userId)
        {
            return orders.Where(o => o.UserId == _userId).ToList();

        }

        public OrderData ExecuteCreateOrderAction(OrderCreateDto _order)
        {
            OrderData newOrder = new OrderData()
            {
                Id = _nextId++,
                UserId = _order.UserId,
                Items = _order.Items,
                TotalPrice = _order.Items.Sum(i => i.Price * i.Quantity),
                Status = OrderStatus.New,
            };
            orders.Add(newOrder);
            return newOrder;
        }

    }
}
