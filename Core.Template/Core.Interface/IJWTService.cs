using Core.Tool.ManagementClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interface
{
    public interface IJWTService
    {
        /// <summary>
        /// 根据一个对象通过反射提供负载生成token
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="user"></param>
        /// <returns></returns>
        TnToken CreateToken<T>(T user) where T : class;
    }
}
