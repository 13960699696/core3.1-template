using Core.Interface;
using Core.Tool.ManagementClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
    public class UserService : IUserService
    {
        //模拟测试，默认都是人为验证有效
        public bool IsValid(LoginRequestDTO req)
        {
            //模拟用户请求都是正确的
            return true;
        }
    }
}
