using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Product;
using TKDequipShop.Domains.Entities.User;

namespace TKDequipShop.BusinessLogic.Core
{
    public class UserActions
    {
        static List<UserData> users = new List<UserData>();
        static int _nextId = 1;
        public List<UserData> ExecuteGetAllUsersAction()
        {
            return users;
        }


    }
}
