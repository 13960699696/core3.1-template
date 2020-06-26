using Core.Tool.ManagementClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interface
{
    public interface IUserService
    {
        bool IsValid(LoginRequestDTO req);
    }
}
