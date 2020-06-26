using Core.Interface;
using Core.Tool.ManagementClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly IJWTService _jWTService;
        public AuthenticationService(IUserService userService, IJWTService jWTService)
        {
            _userService = userService;
            _jWTService = jWTService;
        }
        public bool IsAuthenticated(LoginRequestDTO request, out TnToken token)
        {
            token = null;
            if (!_userService.IsValid(request))
                return false;
            TnToken data = _jWTService.CreateToken<LoginRequestDTO>(request);
            token = data;
            return true;
        }
    }
}
