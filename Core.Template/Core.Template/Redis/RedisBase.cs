using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Template.Redis
{
    /// <summary>
    /// RedisBase类，是redis操作的基类，继承自IDisposable接口，主要用于释放内存
    /// </summary>
    public abstract class RedisBase : IDisposable
    {
        /// <summary>
        /// 保存redis客户端字段
        /// </summary>
        public IRedisClient iClient { get; private set; }
        /// <summary>
        /// 构造时完成链接的打开
        /// </summary>
        public RedisBase()
        {
            iClient = RedisManager.GetClient();
        }
        private bool _disposed = false;
        /// <summary>
        /// 释放redis
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    iClient.Dispose();
                    iClient = null;
                }
            }
            this._disposed = true;
        }
        /// <summary>
        /// 强制释放redis
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// 清除全部数据 请小心
        /// </summary>
        public virtual void FlushAll()
        {
            iClient.FlushAll();
        }
        /// <summary>
        /// 保存数据DB文件到硬盘
        /// </summary>
        public void Save()
        {
            iClient.Save();//阻塞式save
        }
        /// <summary>
        /// 异步保存数据DB文件到硬盘
        /// </summary>
        public void SaveAsync()
        {
            iClient.SaveAsync();//异步save
        }
    }
}
