using EasyNetQ;
using EasyNetQ.Topology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Template.RabbitMq
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMessageConsume
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void Consume(string message);
    }
}
