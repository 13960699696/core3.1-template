using Core.Interface;
using Core.Tool.ManagementClass;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;

namespace Core.Service
{
    /**
    *JWT的组成：Header.Payload.SIGNATURE
    //Header:{"alg":"HS256","typ":"JWT"}  alg为加密算法,typ为签名类型  BASE64编码
    //Payload:声明信息（claim）包含用户名，角色，过期日期等  BASE64编码
    //SIGNATURE:HS256(BASE64(Header).Base64(Payload),secret)
    * */
    /**
    * Claims (Payload)
    Claims 部分包含了一些跟这个 token 有关的重要信息。 JWT 标准规定了一些字段，下面节选一些字段:
    nbf：在此之前不可用
    aud：Token接受者
    iss: The issuer of the token，token 是给谁的
    sub: The subject of the token，token 主题
    exp: Expiration Time。 token 过期时间，Unix 时间戳格式
    iat: Issued At。 token 创建时间， Unix 时间戳格式
    jti: JWT ID。针对当前 token 的唯一标识
    除了规定的字段外，可以包含其他任何 JSON 兼容的字段。
    * */
    public class JWTService : IJWTService
    {
        private readonly TokenManagement _tokenManagement;
        public JWTService(IOptions<TokenManagement> tokenManagement)
        {
            _tokenManagement = tokenManagement.Value;
        }
        /// <summary>
        /// 根据一个对象通过反射提供负载生成token
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="user"></param>
        /// <returns></returns>
        public TnToken CreateToken<T>(T user) where T : class
        {
            //携带的负载部分，类似一个键值对
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            //这里我们用反射把model数据提供给它
            foreach (PropertyInfo item in user.GetType().GetProperties())
            {
                object obj = item.GetValue(user,null);
                string value = "";
                if (obj != null)
                    value = obj.ToString();
                keyValuePairs.Add(item.Name, value);
            }
            //创建token
            return CreateToken(keyValuePairs);
        }

        /// <summary>
        /// 根据键值对提供负载生成token
        /// </summary>
        /// <param name="keyValuePairs"></param>
        /// <returns></returns>
        public TnToken CreateToken(Dictionary<string, string> keyValuePairs)
        {
            //携带的负载部分，类似一个键值对
            List<Claim> claims = new List<Claim>();
            //这里我们通过键值对把数据提供给它
            foreach (var item in keyValuePairs)
            {
                claims.Add(new Claim(item.Key, item.Value));
            }
            //创建token
            return CreateTokenString(claims);
        }
        /// <summary>
        /// 生成token
        /// </summary>
        /// <param name="claims">List的 Claim对象</param>
        /// <returns></returns>
        private TnToken CreateTokenString(List<Claim> claims)
        {
            var now = DateTime.Now;
            var expires = now.Add(TimeSpan.FromMinutes(Convert.ToDouble(_tokenManagement.AccessExpiration)));
            var token = new JwtSecurityToken(
                issuer: _tokenManagement.Issuer,//Token发布者
                audience: _tokenManagement.Audience,//Token接受者
                claims: claims,//携带的负载
                notBefore: now,//当前时间token生成时间
                expires: expires,//过期时间
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenManagement.Secret)), SecurityAlgorithms.HmacSha256));
            return new TnToken { TokenStr = new JwtSecurityTokenHandler().WriteToken(token), Expires = expires };
        }
    }
}
