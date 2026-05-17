using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Entities.User;
using TKDequipShop.Domains.Models.Auth;

namespace TKDequipShop.BusinessLogic.Functions
{
    public class AuthFlow : AuthActions, IAuthActions
    {
        private TokenService _tokenService = new TokenService();

        public string LoginAction(LoginDto _login)
        {
            var user = ExecuteLoginAction(_login);
            if (user == null) return null;
            return _tokenService.GenerateToken(user);
        }

        public string RegisterAction(RegisterDto _register)
        {
            var user = ExecuteRegisterAction(_register);
            if (user == null) return null;
            return _tokenService.GenerateToken(user);
        }
        public UserData GetUserByIdAction(int _userId)
        {
            return ExecuteGetUserByIdAction(_userId);
        }
    }
}
