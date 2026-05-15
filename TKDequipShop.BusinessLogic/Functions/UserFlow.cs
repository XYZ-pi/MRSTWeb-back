using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Models.Product;
using TKDequipShop.Domains.Models.User;

namespace TKDequipShop.BusinessLogic.Functions
{
    public class UserFlow : UserActions, IUserActions
    {
        public List<UserResponseDto> GetAllUsersAction()
        {
            var users = ExecuteGetAllUsersAction();
            List<UserResponseDto> usersDto = new List<UserResponseDto>();

            foreach (var user in users)
            {
                var userRespDto = new UserResponseDto()
                {
                        Id = user.Id,
                        UserName = user.UserName,
                        Email = user.Email,
                };
                usersDto.Add(userRespDto);

            }
            return usersDto;
        }

    }
}

