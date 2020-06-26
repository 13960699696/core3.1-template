using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Template.RabbitMq
{
    /// <summary>
    /// 发送消息接口
    /// </summary>
    internal interface ISend
    {
        Task SendMsgAsync(PushMsg pushMsg, IBus bus);

        void SendMsg(PushMsg pushMsg, IBus bus);
    }
}
