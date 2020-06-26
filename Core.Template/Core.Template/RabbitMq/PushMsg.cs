using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Template.RabbitMq
{
    /// <summary>
    /// 定义的枚举
    /// </summary>
    public enum SendEnum
    {
        /// <summary>
        /// 
        /// </summary>
        订阅模式 = 1,
        /// <summary>
        /// 
        /// </summary>
        推送模式 = 2,
        /// <summary>
        /// 
        /// </summary>
        主题路由模式 = 3
    }
    /// <summary>
    /// 发送消息的类
    /// </summary>
    public class PushMsg
    {
        /// <summary>
        /// 发送的数据
        /// </summary>
        public object sendMsg { get; set; }

        /// <summary>
        /// 消息推送的模式
        /// 现在支持：订阅模式,推送模式,主题路由模式
        /// </summary>
        public SendEnum sendEnum { get; set; }

        /// <summary>
        /// 管道名称
        /// </summary>
        public string exchangeName { get; set; }

        /// <summary>
        /// 路由名称
        /// </summary>
        public string routeName { get; set; }
    }
}
