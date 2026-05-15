using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Models.User;

namespace TKDequipShop.BusinessLogic.Interfaces
{
    public interface IUserActions
    {
        public List<UserResponseDto> GetAllUsersAction();

        public UserResponseDto CreateNewUserAction(UserCreateDto _user);
    }
}
