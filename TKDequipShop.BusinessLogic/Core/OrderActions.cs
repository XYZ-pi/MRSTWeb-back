using Microsoft.EntityFrameworkCore;
using TKDequipShop.DataAccess.Context;
using TKDequipShop.Domains.Entities.Order;
using TKDequipShop.Domains.Enums.Order;
using TKDequipShop.Domains.Models.Order;

namespace TKDequipShop.BusinessLogic.Core
{
    public class OrderActions
    {
        protected AppDbContext _db = new AppDbContext();

        public List<OrderData> ExecuteGetAllOrdersOfUserAction(int _userId)
        {
            return _db.OrderDatas.Where(o => o.UserId == _userId).ToList();
        }

        public OrderData ExecuteCreateOrderAction(int _userId, OrderCreateDto _order)
        {
            var userExists = _db.UserDatas.Any(u => u.Id == _userId);
            if (!userExists) return null;
            OrderData newOrder = new OrderData()
            {
                UserId = _userId,
                Items = _order.Items.Select(i => new OrderItemData
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Price = i.Price,
                    Quantity = i.Quantity,
                    UnitPrice = i.Price,
                }).ToList(),

                TotalPrice = _order.Items.Sum(i => i.Price * i.Quantity),
                Status = OrderStatus.New,
            };
            _db.OrderDatas.Add(newOrder);
            _db.SaveChanges();
            return newOrder;
        }

        public OrderData ExecuteUpdateOrderStatusAction(int _orderId, OrderStatus _status)
        {
            var order = _db.OrderDatas.FirstOrDefault(o => o.Id == _orderId);
            if (order == null) return null;
            order.Status = _status;
            _db.SaveChanges();
            return order;
        }

        public bool ExecuteDeleteOrderAction(int _orderId)
        {
            var order = _db.OrderDatas
                .Include(o => o.Items)
                .FirstOrDefault(o => o.Id == _orderId);
            if (order == null) return false;
            _db.OrderItemDatas.RemoveRange(order.Items);
            _db.OrderDatas.Remove(order);
            _db.SaveChanges();
            return true;
        }
    }
}