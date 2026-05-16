using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Models.Order;
using TKDequipShop.Domains.Entities.Order;
using TKDequipShop.Domains.Enums.Order;

namespace TKDequipShop.BusinessLogic.Interfaces
{
    public interface IOrderActions
    {
        public List<OrderData> GetAllOrdersOfUserAction(int _userId);
        public OrderResponseDto CreateOrderAction(OrderCreateDto _order);
        public OrderResponseDto UpdateOrderStatusAction(int _orderId, OrderStatus _status);
        public bool DeleteOrderAction(int _orderId);

    }
}
