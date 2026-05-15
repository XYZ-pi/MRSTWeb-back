using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Entities.Order;
using TKDequipShop.Domains.Models.Order;
using TKDequipShop.Domains.Models.Product;

namespace TKDequipShop.BusinessLogic.Functions
{
    public class OrderFlow : OrderActions, IOrderActions
    {
        public List<OrderResponseDto> GetAllOrdersOfUserAction(int _userId)
        {
            var orders = GetAllOrdersOfUserAction(_userId);
            List<OrderResponseDto> ordersDto = new List<OrderResponseDto>();

            foreach (var order in orders)
            {
                var orderRespDto = new OrderResponseDto()
                {
                    Id = order.Id,
                    UserId = order.UserId,
                    TotalPrice = order.TotalPrice,
                };
                ordersDto.Add(orderRespDto);

            }
            return ordersDto;
        }
    }
}
