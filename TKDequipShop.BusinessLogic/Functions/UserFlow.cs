using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Enums.User;
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
                    Role = user.Role,           
                    IsActive = user.IsActive,   
                    CreatedAt = user.CreatedAt, 
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
                Role = newUser.Role,
                IsActive = newUser.IsActive,
                CreatedAt = newUser.CreatedAt,

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
                Role = updatedUser.Role,
                IsActive = updatedUser.IsActive,
                CreatedAt = updatedUser.CreatedAt,
            };

            return updatedUserDto;
        }

        public bool DeleteUserAction(int id)
        {
            return ExecuteDeleteUserAction(id);

        }

        public UserResponseDto GetUserByIdAction(int id)
        {
            var foundUser = ExecuteGetUserByIdAction(id);

            if (foundUser == null) return null;
            UserResponseDto foundUserDto = new UserResponseDto()
            {
                Id = foundUser.Id,
                UserName = foundUser.UserName,
                Email = foundUser.Email,
                Gender = foundUser.Gender,
                Role = foundUser.Role,
                IsActive = foundUser.IsActive,
                CreatedAt = foundUser.CreatedAt,
            };

            return foundUserDto;
        }

        public bool ChangeRoleAction(int _userId, UserRole _role)
            => ExecuteChangeRoleAction(_userId, _role);

        public bool ToggleActiveAction(int _userId)
            => ExecuteToggleActiveAction(_userId);


    }
}

