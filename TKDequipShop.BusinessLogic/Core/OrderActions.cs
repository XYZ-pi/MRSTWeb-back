using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Product;
using TKDequipShop.Domains.Entities.Order;

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
    }
}
