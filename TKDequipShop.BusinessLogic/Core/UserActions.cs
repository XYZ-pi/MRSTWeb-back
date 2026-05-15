using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Product;
using TKDequipShop.Domains.Entities.User;
using TKDequipShop.Domains.Models.Product;
using TKDequipShop.Domains.Models.User;

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

        public UserData ExecuteCreateNewUsersAction(UserCreateDto _user)
        {
            UserData newUser = new UserData()
            {
                Id = _nextId++,
                UserName = _user.UserName,
                Email = _user.Email,
                Password = _user.Password,
                DefaultPaymentMethod = _user.DefaultPaymentMethod,
                DOB = _user.DOB,
                Gender = _user.Gender,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            users.Add(newUser);

            return newUser;
        }
    }
}
