using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Entities.Order;
using TKDequipShop.Domains.Enums.Order;
using TKDequipShop.Domains.Models.Order;
using TKDequipShop.Domains.Models.Product;

namespace TKDequipShop.BusinessLogic.Functions
{
    public class OrderFlow : OrderActions, IOrderActions
    {
        public List<OrderResponseDto> GetAllOrdersOfUserAction(int _userId)
        {
            var orders = ExecuteGetAllOrdersOfUserAction(_userId);
            List<OrderResponseDto> ordersDto = new List<OrderResponseDto>();
            foreach (var order in orders)
            {
                ordersDto.Add(new OrderResponseDto()
                {
                    Id = order.Id,
                    UserId = order.UserId,
                    Items = order.Items,
                    TotalPrice = order.TotalPrice,
                    Status = order.Status,
                });
            }
            return ordersDto;
        }

        public OrderResponseDto CreateOrderAction(int _userId, OrderCreateDto _order)
        {
            var order = ExecuteCreateOrderAction(_userId, _order);
            if (order == null) return null;
            return new OrderResponseDto()
            {
                Id = order.Id,
                UserId = order.UserId,
                Items = order.Items,
                TotalPrice = order.TotalPrice,
                Status = order.Status,
            };
        }

        public OrderResponseDto UpdateOrderStatusAction(int _orderId, OrderStatus _status)
        {
            var order = ExecuteUpdateOrderStatusAction(_orderId, _status);
            if (order == null) return null;
            return new OrderResponseDto()
            {
                Id = order.Id,
                UserId = order.UserId,
                Items = order.Items,
                TotalPrice = order.TotalPrice,
                Status = order.Status,
            };
        }

        public bool DeleteOrderAction(int _orderId)
        {
            return ExecuteDeleteOrderAction(_orderId);
        }
    }
}
