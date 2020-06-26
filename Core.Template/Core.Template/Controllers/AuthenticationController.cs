using Core.Interface;
using Core.Tool.ManagementClass;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Core.Template.Controllers
{
    /// <summary>
    /// 权限认证控制器
    /// </summary>
    [Route("api/[controller]"),ApiController,Authorize]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authService;
        private readonly ILogger<AuthenticationController> _logger;
        /// <summary>
        /// 权限认证构造函数
        /// </summary>
        public AuthenticationController(IAuthenticationService authService, ILogger<AuthenticationController> logger)
        {
            _logger = logger;
            _authService = authService;
        }
        /// <summary>
        /// 签发token
        /// </summary>
        [AllowAnonymous,HttpPost, Route("requestToken")]
        public string RequestToken([FromBody] LoginRequestDTO request)
        {
            if (!ModelState.IsValid)
            {
                return "Invalid Request";
            }

            if (_authService.IsAuthenticated(request, out TnToken token))
            {
                return JsonConvert.SerializeObject(new
                {
                    data = token
                });
            }
            return "Invalid Request";
        }
        /// <summary>
        /// 测试
        /// </summary>
        [AllowAnonymous, HttpGet, Route("test")]
        public void test()
        {

        }
    }
}
