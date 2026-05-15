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

        public UserResponseDto CreateNewUserAction(UserCreateDto _user)
        {
            var newUser = ExecuteCreateNewUsersAction(_user);
            UserResponseDto newUserDto = new UserResponseDto()
            {
                Id = newUser.Id,
                UserName = newUser.UserName,
                Email = newUser.Email,
                Gender = newUser.Gender,

            };
            return newUserDto;
        }

        public UserResponseDto UpdateUserAction(int id, UserCreateDto _user)
        {
            var updatedUser = ExecuteUpdateUserAction(id, _user);

            UserResponseDto updatedUserDto = new UserResponseDto()
            {
                Id = updatedUser.Id,
                UserName = updatedUser.UserName,
                Email = updatedUser.Email,
                Gender = updatedUser.Gender,
            };

            return updatedUserDto;
        }
    }
}

