using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Enums.User;
using TKDequipShop.Domains.Models.User;

namespace TKDequipShop.BusinessLogic.Interfaces
{
    public interface IUserActions
    {
        public UserResponseDto CreateNewUserAction(UserCreateDto _user);
        public UserResponseDto UpdateUserAction(int id, UserCreateDto _user);
        public UserResponseDto GetUserByIdAction(int id);
        List<UserResponseDto> GetAllUsersAction();
        bool DeleteUserAction(int _userId);
        bool ChangeRoleAction(int _userId, UserRole _role);
        bool ToggleActiveAction(int _userId);
    }
}
