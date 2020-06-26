using Core.Tool.ManagementClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interface
{
    public interface IAuthenticationService
    {
        bool IsAuthenticated(LoginRequestDTO request, out TnToken token);
    }
}
